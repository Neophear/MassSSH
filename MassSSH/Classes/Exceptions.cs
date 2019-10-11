using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassSSH
{
    public class ConnectionFailedException : Exception
    {
        public ConnectionFailedException() : base("Could not connect") { }
    }

    public class NoValueException : Exception
    {
        public NoValueException() : base("Value can not be empty") { }
    }
}
