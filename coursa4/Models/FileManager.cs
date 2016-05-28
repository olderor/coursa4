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
    /// <summary>
    /// Класс, отвечающий за чтение и сохранение данных.
    /// </summary>
    class FileManager
    {
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="path"> Путь к файлу. </param>
        public FileManager(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Чтение данных из файла.
        /// </summary>
        /// <returns> Возвращает объект, который был сохранен по заданному пути. В случае, если прочесть невозможно, возвращает null. </returns>
        public object Read()
        {
            // Проверка на существование файла
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

        /// <summary>
        /// Сохранение объекта.
        /// </summary>
        /// <param name="obj"> Объект, который необходимо сохранить. </param>
        public void Save(object obj)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Path,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        /// <summary>
        /// Добавление записи в конец файла без его перезаписи.
        /// </summary>
        /// <param name="str">Строка, которую необходимо записать. </param>
        private void WriteLine(string str)
        {
            StreamWriter sw = new StreamWriter(Path, true);
            sw.WriteLine(str);
            sw.Close();
        }

        /// <summary>
        /// Функция, которая делает запись об ошибке. 
        /// </summary>
        /// <param name="e"> Ошибка. </param>
        public void LogError(Exception e)
        {
            FileManager fm = new FileManager("errors.txt");
            fm.WriteLine(DateTime.Now.ToString() + " - Exception in FileManager Read with Path: " + Path + "; Message: " + e.Message);
        }
    }
}
