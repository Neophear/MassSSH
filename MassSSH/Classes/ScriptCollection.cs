using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using Stiig;

namespace MassSSH
{
    /// <summary>
    /// A collection of scripts
    /// </summary>
    public class ScriptCollection : INotifyPropertyChanged
    {
        private string savedPath { get; set; }
        [XmlIgnore]
        public string SavedPath { get { return savedPath; } }
        private MinListe<Script> scripts = new MinListe<Script>();

        public event PropertyChangedEventHandler PropertyChanged;

        public MinListe<Script> Scripts
        {
            get { return scripts; }
        }

        public bool IsEmpty { get { return scripts.Count == 0; } }

        public ScriptCollection()
        {
            scripts.ItemPropertyChanged += Scripts_ItemPropertyChanged;
        }

        private void Scripts_ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChange(sender, e);
        }

        public Script AddScript(string Name)
        {
            Script s = new Script(Name);
            scripts.Add(s);
            return s;
        }

        public void RemoveScript(Script s)
        {
            scripts.Remove(s);
        }

        private void PropertyChange(string property)
        {
            PropertyChange(this, new PropertyChangedEventArgs(property));
        }

        private void PropertyChange(object sender, PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(sender, e);
        }

        public static void Serialize(ScriptCollection scol, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ScriptCollection));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, scol);
            }

            scol.savedPath = path;
        }

        public static ScriptCollection Deserialize(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(ScriptCollection));
            ScriptCollection scol;
            using (TextReader reader = new StreamReader(path))
            {
                try
                {
                    object obj = deserializer.Deserialize(reader);
                    scol = (ScriptCollection)obj;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            scol.savedPath = path;
            return scol;
        }
    }
}