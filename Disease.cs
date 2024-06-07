using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public abstract class DiseaseBase
    {
        public string Name { get; set; }
        public string Symptoms { get; set; }
        public virtual double CalculateSeverityIndex()
        {
            return 0;
        }
    }
    public class Disease : DiseaseBase
    {
        public string Procedures { get; set; }
        public string RecommendedMedicines { get; set; }
        public int Dot { get; set; }
        public int SeverityLevel { get; set; }
        public double MortalityRate { get; set; }
        public bool IsContagious { get; set; }
        public override double CalculateSeverityIndex()
        {
            return SeverityLevel * Dot;
        }
        public double GetSeverityIndex()
        {
            return CalculateSeverityIndex();
        }
        public Disease()
        {
        }
        public Disease(string name, string symptoms, string procedures, string recommendedMedicines, int dot, int severityLevel, double mortalityRate, bool isContagious)
        {
            Name = name;
            Symptoms = symptoms;
            Procedures = procedures;
            RecommendedMedicines = recommendedMedicines;
            Dot = dot;
            SeverityLevel = severityLevel;
            MortalityRate = mortalityRate;
            IsContagious = isContagious;
        }
    }
}
