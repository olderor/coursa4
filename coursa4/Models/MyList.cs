using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4
{
    static class MyList
    {
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
