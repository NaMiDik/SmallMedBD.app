using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public class Med_Actions : MIActions_Table
    {
        private List<MedicineStock> medicinestocks;
        public List<MedicineStock> Search(List<MedicineStock> stockList, int someKey, string text)
        {
            List<MedicineStock> searchList = new List<MedicineStock>();

            switch (someKey)
            {
                case 0:
                    searchList = stockList.Where(medicinestock => medicinestock.Name.ToLower().Contains(text.ToLower())).ToList();
                    break;
            }
            return searchList;
        }
        public List<MedicineStock> Sort(List<MedicineStock> stockList, int sortBy)
        {
            List<MedicineStock> sortedList = new List<MedicineStock>(stockList);
            switch (sortBy)
            {
                case 0:
                    sortedList.Sort((medicinestock1, medicinestock2) => medicinestock1.Name.CompareTo(medicinestock2.Name));
                    break;
                case 1:
                    sortedList.Sort((medicinestock1, medicinestock2) => medicinestock1.Quantity.CompareTo(medicinestock2.Quantity));
                    break;
                case 2:
                    sortedList.Sort((medicinestock1, medicinestock2) => medicinestock1.Price.CompareTo(medicinestock2.Price));
                    break;
            }
            return sortedList;
        }
        public List<MedicineStock> Filter(List<MedicineStock> stockList, int filter, int value)
        {
            medicinestocks = new List<MedicineStock>();
            MedicineStock[] medicinestock_Arr = stockList.ToArray();
            if (filter == 0)
            {
                for (int i = 0; i < medicinestock_Arr.Length; i++)
                {
                    if (medicinestock_Arr[i].Price >= value)
                    {
                        medicinestocks.Add(medicinestock_Arr[i]);
                    }
                }
            }
            else if (filter == 1)
            {
                for (int i = 0; i < medicinestock_Arr.Length; i++)
                {
                    if (medicinestock_Arr[i].Price <= value)
                    {
                        medicinestocks.Add(medicinestock_Arr[i]);
                    }
                }
            }
            return medicinestocks;
        }
    }
}
