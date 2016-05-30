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

        /// <summary>
        /// </summary>
        /// <param name="path"> Путь к файлу. </param>
        public FileManager(string path)
        {
            Path = path;
        }

        public string Path { get; set; }

        /// <summary>
        /// Чтение данных из файла.
        /// </summary>
        /// <returns> Возвращает коллекцию, которая была сохранена по заданному пути.
        /// В случае, если прочесть невозможно, возвращает null. </returns>
        public TravelAgencyCollection ReadCollection()
        {
            return Read() as TravelAgencyCollection;
        }

        /// <summary>
        /// Сохранение коллекции.
        /// </summary>
        /// <param name="collection"> коллекция, которую необходимо сохранить. </param>
        public void SaveCollection(TravelAgencyCollection collection)
        {
            Save(collection);
        }

        /// <summary>
        /// Чтение данных из файла.
        /// </summary>
        /// <returns> Возвращает объект, который был сохранен по заданному пути.
        /// В случае, если прочесть невозможно, возвращает null. </returns>
        private object Read()
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
            catch { }

            stream.Close();
            return null;
        }

        /// <summary>
        /// Сохранение объекта.
        /// </summary>
        /// <param name="obj"> Объект, который необходимо сохранить. </param>
        private void Save(object obj)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Path,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();
        }
    }
}
