using System.ComponentModel;
using System.Linq;
using Stiig;

namespace MassSSH
{
    public class Script : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    PropertyChange("Name");
                }
            }
        }

        private MinListe<Host> hosts = new MinListe<Host>();
        public MinListe<Host> Hosts { get { return hosts; } }

        private string[] commands;
        public string[] Commands
        {
            get { return commands; }
            set
            {
                if ((commands != null && value == null) || (commands == null && value != null) || !Enumerable.SequenceEqual(commands, value))
                {
                    commands = value;
                    PropertyChange("Commands");
                }
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public Script()
        {
            hosts.ItemPropertyChanged += Hosts_ItemPropertyChanged;
        }

        private void Hosts_ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChange(sender, e);
        }

        public Script(string name)
            : this()
        {
            Name = name;
        }

        public void AddHost(Host host)
        {
            hosts.Add(host);
        }

        public void RemoveHost(Host host)
        {
            hosts.Remove(host);
        }

        public override string ToString()
        {
            return Name;
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
    }
}
