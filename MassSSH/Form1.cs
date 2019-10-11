using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using Renci.SshNet;
using Stiig;

namespace MassSSH
{
    public partial class Form1 : Form
    {
        SSHCOM scom = new SSHCOM();
        ScriptCollection scol = new ScriptCollection();
        Timer tmrResetBottomText = new Timer();
        ToolStripItemCollection hostMenuItems;
        string appDataPath;
        string latestPath;
        FilePathCollection fpcLatest;
        string[] args;
        BackgroundWorker wrkrRunScript = new BackgroundWorker();
        bool saved = true;

        public Form1(string[] args)
        {
            InitializeComponent();
            this.args = args;
            this.Text = "Nyt script";
            tssBottom.Text = String.Empty;
            tmrResetBottomText.Interval = 4000;
            tmrResetBottomText.Tick += TmrResetBottomText_Tick;
            wrkrRunScript.DoWork += WrkrRunScript_DoWork;
            wrkrRunScript.RunWorkerCompleted += WrkrRunScript_RunWorkerCompleted;
            wrkrRunScript.WorkerSupportsCancellation = true;

            scol.PropertyChanged += Scol_PropertyChanged;
            hostMenuItems = mnuHost.DropDownItems;
            appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MassSSH\\";
            latestPath = appDataPath + "latest.xml";
            Directory.CreateDirectory(appDataPath);

            try
            {
                fpcLatest = FilePathCollection.Deserialize(latestPath);
                RefreshLatestMenu();
            }
            catch (FileNotFoundException)
            {
                fpcLatest = new FilePathCollection();
            }
            catch (InvalidOperationException)
            {
                fpcLatest = new FilePathCollection();
            }
        }

        private void Scol_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender.GetType() == typeof(Host))
            {
                Host selectedHost = (Host)lstbxHosts.SelectedItem;
                lstbxHosts.DataSource = null;
                lstbxHosts.DataSource = ((Script)lstbxScripts.SelectedItem).Hosts;
                lstbxHosts.SelectedIndex = selectedHost != null ? lstbxHosts.Items.IndexOf(selectedHost) : -1;
            }
            else if (sender.GetType() == typeof(Script) && e.PropertyName != "Commands")
            {
                Script selectedScript = (Script)lstbxScripts.SelectedItem;
                lstbxScripts.DataSource = null;
                lstbxScripts.DataSource = scol.Scripts;
                lstbxScripts.SelectedIndex = selectedScript != null ? lstbxScripts.Items.IndexOf(selectedScript) : -1;
            }
            
            ScolChanged();
        }

        private void RefreshLatestMenu()
        {
            mnuFileLatest.DropDownItems.Clear();

            foreach (string fp in fpcLatest)
                mnuFileLatest.DropDownItems.Add(new ToolStripMenuItem(fp));

            mnuFileLatest.Enabled = mnuFileLatest.HasDropDownItems;
        }

        private void TmrResetBottomText_Tick(object sender, EventArgs e)
        {
            tmrResetBottomText.Stop();
            tssBottom.Text = String.Empty;
        }

        private void WriteOutput(string text) { WriteOutput(text, true); }
        private void WriteOutput(string text, bool startNewLine)
        {
            //text = Regex.Replace(text, @"\eE", Environment.NewLine);
            text = Regex.Replace(text, @"\e(\[(\d+;)*(\??\d+)?[ABCDHJKfhlmrsu])|\eE", "");
            Action actnWriteOutput = () => txtOutput.AppendText((startNewLine && !String.IsNullOrEmpty(txtOutput.Text) ? Environment.NewLine : "") + text);
            txtOutput.Invoke(actnWriteOutput);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            wrkrRunScript.RunWorkerAsync();
        }

        private void WrkrRunScript_DoWork(object sender, DoWorkEventArgs e)
        {
            Action actnEnableDisableButtons = () => btnRun.Enabled = !(btnStop.Enabled = true);
            btnRun.Invoke(actnEnableDisableButtons);
            MinListe<Script> scripts = new MinListe<Script>();

            if (e.Argument != null)
                scripts.Add((Script)e.Argument);
            else
                scripts = scol.Scripts;

            foreach (Script script in scripts)
            {
                WriteOutput($"---Running script: {script.Name}");

                foreach (Host host in script.Hosts)
                {
                    if (wrkrRunScript.CancellationPending) break;
                    WriteOutput($"Connecting to {host.Name}... ");

                    //if (host.ConType == null)
                    //    WriteOutput("Connection-mode has not been set!", false);
                    //else
                    //{
                    try
                    {
                        //if (host.ConType == connectionType.SSH)
                        //{
                        using (SshClient client = new SshClient(host.Address, txtUsername.Text, txtPassword.Text))
                        {
                            if (wrkrRunScript.CancellationPending) break;
                            client.Connect();

                            if (client.IsConnected)
                            {
                                if (wrkrRunScript.CancellationPending) break;
                                WriteOutput("Connected!", false);

                                using (ShellStream ss = client.CreateShellStream("dumb", 80, 24, 800, 600, 1024))
                                {
                                    WriteOutput(scom.ReadToEnd(ss, 300), false);
                                    foreach (string c in script.Commands)
                                    {
                                        if (wrkrRunScript.CancellationPending) break;
                                        //WriteOutput(scom.SendCommandCR(c, ss, 300), false);
                                        WriteOutput(scom.SendCommandLF(c, ss, 300), false);
                                    }
                                }

                                client.Disconnect();
                                WriteOutput("Disconnected!", false);
                            }
                            else
                                WriteOutput("Connection failed!", false);
                        }
                            //}
                            //else
                            //{
                            //    if (wrkrRunScript.CancellationPending) break;
                            //    WriteOutput("Connecting to {0}...", host.Name);
                            //    TelnetCOM tc = new TelnetCOM(host.Address, 23);
                            //    string s = tc.Login(txtPassword.Text, 1000);
                            //    string prompt = s.TrimEnd();
                            //    prompt = s.Substring(prompt.Length - 1, 1);
                            //    if (prompt != "$" && prompt != ">")
                            //        WriteOutput("Connection failed!", false);
                            //    else
                            //    {
                            //        foreach (string c in script.Commands)
                            //        {
                            //            if (wrkrRunScript.CancellationPending) break;
                            //            tc.WriteLine(c);
                            //            WriteOutput(tc.Read());
                            //        }
                            //    }
                            //    WriteOutput("Disconnected!");
                            //}
                    }
                    catch (Renci.SshNet.Common.SshAuthenticationException)
                    {
                        WriteOutput("Authentication failed!", false);
                    }
                    catch (ArgumentException ex)
                    {
                        if (ex.Message == "username")
                            WriteOutput("Username missing!", false);
                        else
                            WriteOutput("CAUGHT: " + ex.ToString());
                    }
                    catch (System.Net.Sockets.SocketException se)
                    {
                        switch (se.ErrorCode)
                        {
                            case 10060:
                                WriteOutput("Connection timed out!", false);
                                break;
                            case 11001:
                                WriteOutput("Could not find host!", false);
                                break;
                            default:
                                WriteOutput("CAUGHT: " + se.ToString());
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteOutput("CAUGHT: " + ex.ToString());
                    }
                    //}
                }

                WriteOutput($"---Finished script: {script.Name}{Environment.NewLine}");
            }
        }

        private void WrkrRunScript_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStop.Enabled = false;
            btnRun.Enabled = true;
        }

        private void OpenScriptCol(string path)
        {
            try
            {
                scol = ScriptCollection.Deserialize(path);
                this.Text = Path.GetFileName(scol.SavedPath);

                scol.PropertyChanged += Scol_PropertyChanged;
                lstbxScripts.DataSource = scol.Scripts;
                AddLatest(path);
            }
            catch (FileNotFoundException)
            {
                if (fpcLatest.Exists(x => x == path))
                {
                    if (MessageBox.Show("Filen findes ikke. Fjern fra Seneste?", "Fil ikke fundet", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        fpcLatest.RemoveAt(fpcLatest.FindIndex(x => x == path));
                        RefreshLatestMenu();
                    }
                }
                else
                    MessageBox.Show("Filen findes ikke.");
                
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Kunne ikke åbne. Filen er muligvis korrupt.");
            }
        }

        private void ShowOpenDialog()
        {
            ofdOpen.Filter = "MassSSH-fil|*.msh";
            ofdOpen.Title = "Åben...";
            ofdOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult dr = ofdOpen.ShowDialog();

            if (dr == DialogResult.OK && ofdOpen.CheckFileExists)
                OpenScriptCol(ofdOpen.FileName);
        }

        private void AddLatest(string path)
        {
            fpcLatest.RemoveAll(x => x == path);
            fpcLatest.Insert(0, path);

            if (fpcLatest.Count > 10)
                fpcLatest.RemoveRange(10, fpcLatest.Count - 10);

            RefreshLatestMenu();
        }

        private void SetBottomText(string t)
        {
            tmrResetBottomText.Stop();
            tssBottom.Text = t;
            tmrResetBottomText.Start();
        }

        private void lstbxScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Script script = (Script)lstbxScripts.SelectedItem;

            if (script != null)
            {
                txtCommands.Lines = script.Commands;
                txtCommands.Enabled = true;
                lstbxHosts.DataSource = script.Hosts;
            }
            else
            {
                txtCommands.Text = String.Empty;
                txtCommands.Enabled = false;
                lstbxHosts.DataSource = null;
            }
        }

        private void ScolChanged()
        {
            saved = false;
            this.Text = AddRemoveLastChar(this.Text, '*', AddRemove.Add);
        }

        #region File Menu
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            if (CheckIfSaved())
            {
                scol = new ScriptCollection();
                lstbxScripts.DataSource = null;
                lstbxHosts.DataSource = null;
                saved = true;
                this.Text = "Nyt script";
                txtCommands.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtOutput.Clear();
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            ShowOpenDialog();
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            ShowSaveAsDialog();
        }

        private void ShowSaveAsDialog()
        {
            sfdSaveAs.Filter = "MassSSH-fil|*.msh";
            sfdSaveAs.Title = "Gem som...";
            sfdSaveAs.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult dr = sfdSaveAs.ShowDialog();

            if (dr == DialogResult.OK && sfdSaveAs.FileName != "")
                SaveAs(sfdSaveAs.FileName);
        }

        private void SaveAs(string path)
        {
            ScriptCollection.Serialize(scol, path);
            SetBottomText("Gemt");
            saved = true;
            this.Text = Path.GetFileName(path);
            AddLatest(path);
        }

        private string AddRemoveLastChar(string text, char lchar, AddRemove ar)
        {
            if (ar == AddRemove.Add && text.Last<char>() != lchar)
                text += lchar;
            else if (ar == AddRemove.Remove && text.Last<char>() == lchar)
                text = text.Remove(text.Length - 1);

            return text;
        }

        private enum AddRemove
        {
            Add,
            Remove
        }

        private void mnuFileLatest_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenScriptCol(e.ClickedItem.Text);
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Host Menu
        private void lstbxHosts_MouseDown(object sender, MouseEventArgs e)
        {
            lstbxHosts.SelectedIndex = lstbxHosts.IndexFromPoint(e.X, e.Y);
        }

        private void cmsHost_Opening(object sender, CancelEventArgs e)
        {
            cmsHostDelete.Enabled = cmsHostEdit.Enabled = lstbxHosts.SelectedIndex != -1;
            cmsHostAdd.Enabled = lstbxScripts.SelectedIndex != -1;
            cmsHostMoveUp.Enabled = lstbxHosts.SelectedIndex > 0;
            cmsHostMoveDown.Enabled = lstbxHosts.SelectedIndex != -1 && lstbxHosts.SelectedIndex < (lstbxHosts.Items.Count - 1);
        }

        private void mnuHost_DropDownOpening(object sender, EventArgs e)
        {
            mnuHostEdit.Enabled = mnuHostDelete.Enabled = lstbxHosts.SelectedIndex != -1;
            mnuHostAdd.Enabled = lstbxScripts.SelectedIndex != -1;
            mnuHostMoveUp.Enabled = lstbxHosts.SelectedIndex > 0;
            mnuHostMoveDown.Enabled = lstbxHosts.SelectedIndex != -1 && lstbxHosts.SelectedIndex < (lstbxHosts.Items.Count - 1);
        }

        /// <summary>
        /// Add a new host to the selected script
        /// </summary>
        private void HostAdd(object sender, EventArgs e)
        {
            Script script = (Script)lstbxScripts.SelectedItem;
            int counter = 1;

            while (script.Hosts.Count<Host>(x => x.Name == String.Format("NewHost{0}", counter)) > 0)
                counter++;

            Host host = new Host("NIL", String.Format("NewHost{0}", counter));
            script.AddHost(host);
            lstbxHosts.DataSource = null;
            lstbxHosts.DataSource = script.Hosts;
            lstbxHosts.SelectedIndex = lstbxHosts.Items.Count - 1;
            OpenHostEdit();
        }

        private void HostEdit(object sender, EventArgs e)
        {
            OpenHostEdit();
        }

        /// <summary>
        /// Opens a selected host for editing
        /// </summary>
        private void OpenHostEdit()
        {
            Host h = (Host)lstbxHosts.SelectedItem;
            if (h != null)
            {
                frmHost frm = new frmHost(h);
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Deletes a host from the selected script
        /// </summary>
        private void HostDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker på at du vil slette denne host?", "Slet host", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Host h = (Host)lstbxHosts.SelectedItem;
                if (h != null)
                {
                    Script script = (Script)lstbxScripts.SelectedItem;
                    script.RemoveHost(h);
                    //Hosts_ItemPropertyChanged();
                }
            }
        }

        private void HostMoveUp(object sender, EventArgs e)
        {
            Script script = (Script)lstbxScripts.SelectedItem;
            script.Hosts.Move(lstbxHosts.SelectedIndex, lstbxHosts.SelectedIndex - 1);
        }

        private void HostMoveDown(object sender, EventArgs e)
        {
            Script script = (Script)lstbxScripts.SelectedItem;
            script.Hosts.Move(lstbxHosts.SelectedIndex, lstbxHosts.SelectedIndex + 1);
        }
        #endregion

        #region Script Menu
        private void lstbxScripts_MouseDown(object sender, MouseEventArgs e)
        {
            lstbxScripts.SelectedIndex = lstbxScripts.IndexFromPoint(e.X, e.Y);
        }

        private void mnuScript_DropDownOpening(object sender, EventArgs e)
        {
            mnuScriptEdit.Enabled = mnuScriptDelete.Enabled = lstbxScripts.SelectedIndex != -1;
            mnuScriptRun.Enabled = !wrkrRunScript.IsBusy && lstbxScripts.SelectedIndex != -1;
            mnuScriptMoveUp.Enabled = lstbxScripts.SelectedIndex > 0;
            mnuScriptMoveDown.Enabled = lstbxScripts.SelectedIndex != -1 && lstbxScripts.SelectedIndex < (lstbxScripts.Items.Count - 1);
        }

        private void cmsScripts_Opening(object sender, CancelEventArgs e)
        {
            cmsScriptDelete.Enabled = cmsScriptEdit.Enabled = lstbxScripts.SelectedIndex != -1;
            cmsScriptRun.Enabled = !wrkrRunScript.IsBusy && lstbxScripts.SelectedIndex != -1;
            cmsScriptMoveUp.Enabled = lstbxScripts.SelectedIndex > 0;
            cmsScriptMoveDown.Enabled = lstbxScripts.SelectedIndex != -1 && lstbxScripts.SelectedIndex < (lstbxScripts.Items.Count - 1);
        }

        /// <summary>
        /// Adds a new script
        /// </summary>
        private void ScriptAdd(object sender, EventArgs e)
        {
            int counter = 1;

            while (scol.Scripts.Count<Script>(x => x.Name == String.Format("NewScript{0}", counter)) > 0)
                counter++;
            
            scol.AddScript(String.Format("NewScript{0}", counter));
            lstbxScripts.DataSource = null;
            lstbxScripts.DataSource = scol.Scripts;
            lstbxScripts.SelectedIndex = lstbxScripts.Items.Count - 1;
            OpenScriptEdit();
        }

        private void ScriptEdit(object sender, EventArgs e)
        {
            OpenScriptEdit();
        }

        private void OpenScriptEdit()
        {
            Script s = (Script)lstbxScripts.SelectedItem;
            if (s != null)
            {
                frmScript frm = new frmScript(s);
                frm.ShowDialog();
            }
        }

        private void ScriptDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker på at du vil slette dette script?", "Slet script", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Script s = (Script)lstbxScripts.SelectedItem;
                if (s != null)
                    scol.RemoveScript(s);
            }
        }

        private void ScriptRun(object sender, EventArgs e)
        {
            Script s = (Script)lstbxScripts.SelectedItem;
            wrkrRunScript.RunWorkerAsync(s);
        }

        private void ScriptMoveUp(object sender, EventArgs e)
        {
            scol.Scripts.Move(lstbxScripts.SelectedIndex, lstbxScripts.SelectedIndex - 1);
        }

        private void ScriptMoveDown(object sender, EventArgs e)
        {
            scol.Scripts.Move(lstbxScripts.SelectedIndex, lstbxScripts.SelectedIndex + 1);
        }
        #endregion

        #region Help Menu
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        private static void ShowHelp()
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
        
        private void mnuHelpUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Progammet er kun testet på Cisco netværksudstyr over SSH.\nJeg tager intet ansvar for brug af programmet.");
        }
        #endregion

        private void Save()
        {
            if (!String.IsNullOrWhiteSpace(scol.SavedPath))
                SaveAs(scol.SavedPath);
            else
                ShowSaveAsDialog();
        }

        private void cmsOutputClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = String.Empty;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wrkrRunScript.IsBusy && MessageBox.Show("Script kører. Er du sikker på at du vil afslutte?", "Afslut", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;

            e.Cancel = !CheckIfSaved();
            
            if (!e.Cancel)
                FilePathCollection.Serialize(fpcLatest, latestPath);
        }

        private bool CheckIfSaved()
        {
            if (!saved)
            {
                switch (MessageBox.Show("Vil du gemme ændringer?", "Gem ændringer", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.Cancel:
                        return false;
                    default:
                        break;
                }
            }

            return true;
        }

        private void txtCommands_TextChanged(object sender, EventArgs e)
        {
            if (lstbxScripts.SelectedIndex != -1)
            {
                Script script = (Script)lstbxScripts.SelectedItem;
                script.Commands = txtCommands.Lines;
            }
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            ShowHelp();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (args.Length >= 1)
                OpenScriptCol(args[0]);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wrkrRunScript.CancelAsync();
        }
    }
}