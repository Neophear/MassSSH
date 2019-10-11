using System;
using System.IO;
using System.Threading;
using Renci.SshNet;

namespace MassSSH
{
    class SSHCOM
    {
        static StreamReader reader;
        static StreamWriter writer;

        public string SendCommand(string cmd, ShellStream s, int commandWaitTime)
        {
            try
            {
                reader = new StreamReader(s);
                writer = new StreamWriter(s);
                writer.AutoFlush = true;
                writer.WriteLine(cmd);
                while (s.Length == 0)
                    Thread.Sleep(commandWaitTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SendCommand(" + cmd + ") caught exception: " + ex.ToString());
            }
            return reader.ReadToEnd();
        }

        public string SendCommandW(string cmd, ShellStream s, int commandWaitTime)
        {
            try
            {
                reader = new StreamReader(s);
                writer = new StreamWriter(s);
                writer.AutoFlush = true;
                writer.Write(cmd);
                while (s.Length == 0)
                    Thread.Sleep(commandWaitTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SendCommandW(" + cmd + ") caught exception: " + ex.ToString());
            }
            return reader.ReadToEnd();
        }
        public string SendCommandCR(string cmd, ShellStream s, int commandWaitTime)
        {
            try
            {
                reader = new StreamReader(s);
                writer = new StreamWriter(s);
                writer.AutoFlush = true;
                writer.Write(cmd + '\r');
                while (s.Length == 0)
                    Thread.Sleep(commandWaitTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SendCommandCR(" + cmd + ") caught exception: " + ex.ToString());
            }
            return reader.ReadToEnd();
        }
        public string SendCommandLF(string cmd, ShellStream s, int commandWaitTime)
        {
            try
            {
                reader = new StreamReader(s);
                writer = new StreamWriter(s);
                writer.AutoFlush = true;
                writer.Write(cmd + '\n');
                while (s.Length == 0)
                    Thread.Sleep(commandWaitTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SendCommandLF(" + cmd + ") caught exception: " + ex.ToString());
            }
            return reader.ReadToEnd();
        }

        public string ReadToEnd(ShellStream s, int commandWaitTime)
        {
            reader = new StreamReader(s);

            while (s.Length == 0)
                Thread.Sleep(commandWaitTime);
            return reader.ReadToEnd();
        }
    }
}