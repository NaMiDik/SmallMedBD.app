using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public class Diseases
    {
        public string Name { get; set; } // Назва хвороби
        public string Symptoms { get; set; } // Симптоми
        public string Procedures { get; set; } // Процедури
        public string RecommendedMedicines { get; set; } // Рекомендовані медикаменти
        public int Quantity { get; set; } // Кількість Рекомендованих ліків
        public int Dot {  get; set; } // Тривалість Лікування
        public int SeverityLevel { get; set; } // Рівень тяжкості
        public double MortalityRate { get; set; } // Смертність (у відсотках)
        public bool IsContagious { get; set; } // Чи є заразним
        public double CalculateSeverityIndex()
        {
            // Наприклад, індекс тяжкості може бути обчислений як добуток рівня тяжкості та смертності
            return SeverityLevel * MortalityRate;
        }
        public Diseases()
        {

        }
        public Diseases(string name, string symptoms, string procedures, string recommendedMedicines,
            int quantity, int dot, int severityLevel, double mortalityRate, bool isContagious)
        {
            Name = name;
            Symptoms = symptoms;
            Procedures = procedures;
            RecommendedMedicines = recommendedMedicines;
            Quantity = quantity;
            Dot = dot;
            SeverityLevel = severityLevel;
            MortalityRate = mortalityRate;
            IsContagious = isContagious;
        }

        //public class Сontagious : Disease 
        //{
        //    public string TransmissionMethod { get; set; } // Метод передачі
        //    public int IncubationPeriod { get; set; } // Інкубаційний період

        //    public Contagious(string name, string symptoms, string procedures, Dictionary<string, int> recommendedMedicines,
        //                      int severityLevel, double mortalityRate, bool isContagious,
        //                      string transmissionMethod, int incubationPeriod) :
        //         base(name, symptoms, procedures, recommendedMedicines, severityLevel, mortalityRate, isContagious)
        //    {
        //        TransmissionMethod = transmissionMethod;
        //        IncubationPeriod = incubationPeriod;
        //    }
        //}
        //public class Disease : IComparable<Disease>
        //{
        //    public int SeverityLevel { get; set; } // Перенесено з Diseases

        //    public int CompareTo(Disease other)
        //    {
        //        return this.SeverityLevel.CompareTo(other.SeverityLevel);
        //    }
        //}
    }
}
