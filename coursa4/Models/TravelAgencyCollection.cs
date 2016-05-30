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
            fm.Save(this);
        }

        /// <summary>
        /// Загрузка данных из файла в коллекцию.
        /// </summary>
        public void Read()
        {
            FileManager fm = new FileManager("data.txt");
            object obj = fm.Read();
            TravelAgencyCollection tac = obj as TravelAgencyCollection;
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

        /// <summary>
        /// Фильтрация коллекции.
        /// </summary>
        /// <typeparam name="T"> Тип объекта, список которого нужно отфильтровать. </typeparam>
        /// <param name="list"> Список объектов, который нужно отфильтровать. </param>
        /// <param name="filters"> Массив фильтров. </param>
        /// <returns> Возвращает отфильтрованный список. </returns>
        public static List<T> Filter<T>(List<T> list, string[] filters)
        {
            // Запрос выбора объектов, у которых для каждого из фильтров есть хотя бы одно поле, в котором содержится фильтр.
            List<T> result = list.Where(ta => filters.All(f => ta.GetType().GetProperties().Any(
                p => !p.PropertyType.IsGenericType && p.GetValue(ta).ToString().ToLower().Contains(f.ToLower())
            ))).ToList();
            return result;
        }

        /// <summary>
        /// Сортировка коллекции по параметру.
        /// </summary>
        /// <typeparam name="T"> Тип объекта, список которого нужно упорядочить. </typeparam>
        /// <param name="list"> Список объектов, который нужно упорядочить. </param>
        /// <param name="property"> Поле, по которому нужно упорядочить. </param>
        /// <param name="direction"> Направление упорядочивания. </param>
        /// <returns> Возвращает упорядоченный список. </returns>
        public static List<T> SortBy<T>(List<T> list, string property, ListSortDirection direction = ListSortDirection.Ascending)
        {
            List<T> result;

            // Сортировка списка по значению из заданного поля.
            if (direction == ListSortDirection.Ascending)
                result = list.OrderBy(el => el.GetType().GetProperty(property).GetValue(el, null)).ToList();
            else
                result = list.OrderByDescending(el => el.GetType().GetProperty(property).GetValue(el, null)).ToList();

            return result;
        }

        /// <summary>
        /// Сравнение двух списков.
        /// </summary>
        /// <typeparam name="T"> Тип объектов, которые находятся в списке. </typeparam>
        /// <param name="list1"> Первый список. </param>
        /// <param name="list2"> Второй список. </param>
        /// <returns> Возвращает true, если соответсвующие элементы списков равны, иначе false. </returns>
        public static bool Compare<T>(List<T> list1, List<T> list2)
        {
            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
                if (!list1[i].Equals(list2[i]))
                    return false;

            return true;
        }
    }
}
