using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4
{
    /// <summary>
    /// Синглтон с коллекцией туристических агентств.
    /// </summary>
    [Serializable]
    class TravelAgencyCollection
    {

        private TravelAgencyCollection()
        {

        }

        public BindingList<TravelAgency> TravelAgencies { get; private set; }

        private static TravelAgencyCollection defaultInstance;

        public static TravelAgencyCollection GetDefaultInstance()
        {
            if (defaultInstance == null)
            {
                defaultInstance = new TravelAgencyCollection();
                defaultInstance.Read();
            }
            return defaultInstance;
        }

        /// <summary>
        /// </summary>
        /// <returns> Возвращает список всех туристических агентств. </returns>
        public List<TravelAgency> GetAllTravelAgencies()
        {
            return TravelAgencies.ToList();
        }

        /// <summary>
        /// </summary>
        /// <returns> Возвращает список всех путешествий. </returns>
        public List<Travel> GetAllTravels()
        {
            List<Travel> travels = new List<Travel>();
            foreach (TravelAgency ta in TravelAgencies)
                travels.AddRange(ta.Travels);
            return travels;
        }

        /// <summary>
        /// Сохраняет текущее состояние коллекции.
        /// </summary>
        public void Save()
        {
            FileManager fm = new FileManager("data.txt");
            fm.SaveCollection(this);
        }

        /// <summary>
        /// Загрузка данных из файла в коллекцию.
        /// </summary>
        public void Read()
        {
            FileManager fm = new FileManager("data.txt");
            TravelAgencyCollection tac = fm.ReadCollection();
            if (tac != null && tac.TravelAgencies != null)
            {
                TravelAgencies = tac.TravelAgencies;
            }
            else
            {
                TravelAgencies = new BindingList<TravelAgency>();
            }
        }


        /// <summary>
        /// Удаляет все туристические агентства из коллекции.
        /// </summary>
        public void Clear()
        {
            TravelAgencies.Clear();
        }

        /// <summary>
        /// Добавляет туристическое агентство в коллекцию.
        /// </summary>
        /// <param name="travelAgency"> Туристическое агентство, которое необходимо добавить. </param>
        public void Add(TravelAgency travelAgency)
        {
            TravelAgencies.Add(travelAgency);
        }

        /// <summary>
        /// Удаляет туристическое агентство из коллекции.
        /// </summary>
        /// <param name="travelAgency"> Туристическое агентство, которое необходимо удалить. </param>
        public void Remove(TravelAgency travelAgency)
        {
            TravelAgencies.Remove(travelAgency);
        }
    }
}
