using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace coursa4
{
    class FileManager
    {
        public string Path { get; set; }

        public FileManager(string path)
        {
            Path = path;
        }

        public object Read()
        {
            if (!File.Exists(Path))
            {
                return null;
            }
            Stream stream = new FileStream(Path,
                          FileMode.Open,
                          FileAccess.Read,
                          FileShare.Read);
            try
            {
                IFormatter formatter = new BinaryFormatter();
                object obj = formatter.Deserialize(stream);
                stream.Close();
                return obj;
            }
            catch (Exception e)
            {
                LogError(e);
            }
            stream.Close();
            return null;
        }

        public void Save(object obj)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Path,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        public void WriteLine(string str)
        {
            StreamWriter sw = new StreamWriter(Path, true);
            sw.WriteLine(str);
            sw.Close();
        }

        public void LogError(Exception e)
        {
            FileManager fm = new FileManager("errors.txt");
            fm.WriteLine(DateTime.Now.ToString() + " - Exception in FileManager Read with Path: " + Path + "; Message: " + e.Message);
        }
    }
}
