using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public class Disease_Actions : IActions_Table
    {
        private List<Disease> diseases;
        public List<Disease> Search(List<Disease> stockList, int someKey, string text)
        {
            List<Disease> searchList = new List<Disease>();

            switch (someKey)
            {
                case 0:
                    searchList = stockList.Where(disease => disease.Name.ToLower().Contains(text.ToLower())).ToList();
                    break;
                case 1:
                    searchList = stockList.Where(book => book.Symptoms.ToLower().Contains(text.ToLower())).ToList();
                    break;
                case 2:
                    searchList = stockList.Where(book => book.Procedures.ToLower().Contains(text.ToLower())).ToList();
                    break;
                case 3:
                    searchList = stockList.Where(book => book.RecommendedMedicines.ToLower().Contains(text.ToLower())).ToList();
                    break;
            }
            return searchList;
        }
        public List<Disease> Sort(List<Disease> stockList, int sortBy)
        {
            List<Disease> sortedList = new List<Disease>(stockList);
            switch (sortBy)
            {
                case 0:
                    sortedList.Sort((disease1, disease2) => disease1.Name.CompareTo(disease2.Name));
                    break;
                case 1:
                    sortedList.Sort((disease1, disease2) => disease1.Symptoms.CompareTo(disease2.Symptoms));
                    break;
                case 2:
                    sortedList.Sort((disease1, disease2) => disease1.Procedures.CompareTo(disease2.Procedures));
                    break;
                case 3:
                    sortedList.Sort((disease1, disease2) => disease1.RecommendedMedicines.CompareTo(disease2.RecommendedMedicines));
                    break;
                case 4:
                    sortedList.Sort((disease1, disease2) => disease1.Dot.CompareTo(disease2.Dot));
                    break;
                case 5:
                    sortedList.Sort((disease1, disease2) => disease1.SeverityLevel.CompareTo(disease2.SeverityLevel));
                    break;
                case 6:
                    sortedList.Sort((disease1, disease2) => disease1.MortalityRate.CompareTo(disease2.MortalityRate));
                    break;
                case 7:
                    sortedList.Sort((disease1, disease2) => disease1.IsContagious.CompareTo(disease2.IsContagious));
                    break;
            }
            return sortedList;
        }
        public List<Disease> Filter(List<Disease> stockList, int filter, int value)
        {
            diseases = new List<Disease>();
            Disease[] disease_Arr = stockList.ToArray();
            if (filter == 0)
            {
                for (int i = 0; i < disease_Arr.Length; i++)
                {
                    if (disease_Arr[i].SeverityLevel >= value)
                    {
                        diseases.Add(disease_Arr[i]);
                    }
                }
            }
            else if (filter == 1)
            {
                for (int i = 0; i < disease_Arr.Length; i++)
                {
                    if (disease_Arr[i].SeverityLevel <= value)
                    {
                        diseases.Add(disease_Arr[i]);
                    }
                }
            }
            return diseases;
        }
    }
}
