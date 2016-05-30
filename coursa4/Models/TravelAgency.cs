using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4
{
    [Serializable]
    public class TravelAgency
    {

        public TravelAgency()
        {
            Name = "";
            Address = "";
            Travels = new List<Travel>();
        }

        public TravelAgency(TravelAgency travelAgency)
        {
            Copy(travelAgency);
        }

        public TravelAgency(string name, string address, params Travel[] travels)
        {
            Name = name;
            Address = address;
            Travels = new List<Travel>(travels);
            foreach (Travel t in travels)
                t.Owner = this;
        }

        public TravelAgency(string name, string address, IEnumerable<Travel> travels)
        {
            Name = name;
            Address = address;
            Travels = new List<Travel>(travels.ToList());
            foreach (Travel t in travels)
                t.Owner = this;
        }

        public List<Travel> Travels { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TravelsCount
        {
            get
            {
                return Travels.Count;
            }
        }

        /// <summary>
        /// Копирует данные из туристического агентства в текущий экземпляр.
        /// </summary>
        /// <param name="travelAgency"> Другое туристическое агентстсво. </param>
        public void Copy(TravelAgency travelAgency)
        {
            Name = travelAgency.Name;
            Address = travelAgency.Address;
            Travels = new List<Travel>(travelAgency.Travels);
        }

        /// <summary>
        /// Удаляет путешествие из списка путешествий.
        /// </summary>
        /// <param name="travel"> Путешествие, которое нужно удалить. </param>
        public void Remove(Travel travel)
        {
            Travels.Remove(travel);
        }

        /// <summary>
        /// Добавляет путешествие в список путешествий.
        /// </summary>
        /// <param name="travel"> Путешествие, которое нужно добавить. </param>
        public void Add(Travel travel)
        {
            travel.Owner = this;
            Travels.Add(travel);
        }

        /// <summary>
        /// Проверка на корректность данных.
        /// </summary>
        public bool IsCorrect
        {
            get
            {
                if (Name == "")
                    return false;

                if (Address == "")
                    return false;

                return true;
            }
        }
    }
}
