using System;
using System.ComponentModel;

namespace MassSSH
{
    /// <summary>
    /// A host
    /// </summary>
    public class Host : INotifyPropertyChanged
    {
        //private int _commandWaitTime;
        //public int CommandWaitTime
        //{
        //    get { return _commandWaitTime; }
        //    set
        //    {
        //        if (_commandWaitTime != value)
        //        {
        //            _commandWaitTime = value;
        //            PropertyChange("CommandWaitTime");
        //        }
        //    }
        //}
        //private connectionType? _contype { get; set; }
        //public connectionType? ConType
        //{
        //    get { return _contype; }
        //    set
        //    {
        //        if (_contype != value)
        //        {
        //            _contype = value;
        //            PropertyChange("ConType");
        //        }
        //    }
        //}

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    PropertyChange("Name");
                }
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new NoValueException();
                else if (_address != value)
                {
                    _address = value;
                    PropertyChange("Address");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Host()
        {
            
        }
        public Host(string Address)
        {
            this.Address = Address;
        }
        public Host(string Address, string Name)
            : this(Address)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return String.IsNullOrWhiteSpace(Name) ? _address : Name;
        }

        private void PropertyChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }

    //public enum connectionType
    //{
    //    Telnet,
    //    SSH
    //}
}
