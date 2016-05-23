using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4
{
    [Serializable]
    class TourAgencyCollection : BindingList<TourAgency>
    {
        private static TourAgencyCollection defaultInstance;

        public static TourAgencyCollection GetDefaultInstance()
        {
            if (defaultInstance == null)
            {
                defaultInstance = new TourAgencyCollection();
                defaultInstance.Read();
            }
            return defaultInstance;
        }

        private TourAgencyCollection()
        {

        }

        public List<TourAgency> GetAllTourAgencies()
        {
            return Items.ToList();
        }

        public void Save()
        {
            FileManager fm = new FileManager("data.txt");
            fm.Save(this);
        }
        
        public void Read()
        {
            FileManager fm = new FileManager("data.txt");
            object obj = fm.Read();
            TourAgencyCollection tac = obj as TourAgencyCollection;
            if (tac != null && tac.Items != null)
            {
                ClearItems();
                foreach (TourAgency item in tac.Items)
                    Items.Add(item);
            }
            else
                ClearItems();
        }
    }
}
