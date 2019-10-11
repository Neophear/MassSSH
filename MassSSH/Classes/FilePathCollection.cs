using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MassSSH
{
    public class FilePathCollection : List<string>
    {
        public static void Serialize(FilePathCollection fpc, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FilePathCollection));
            using (TextWriter writer = new StreamWriter(path))
                serializer.Serialize(writer, fpc);
        }

        public static FilePathCollection Deserialize(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(FilePathCollection));
            FilePathCollection fpc;
            using (TextReader reader = new StreamReader(path))
            {
                try
                {
                    object obj = deserializer.Deserialize(reader);
                    fpc = (FilePathCollection)obj;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return fpc;
        }
    }
}
