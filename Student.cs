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
            return CalculateSeverityIndex();
        }
    }
    public class Disease : DiseaseBase
    {
        public string Procedures { get; set; }
        public int Age { get; set; }
        public double Semester { get; set; }
        public double Scholarship { get; set; }
        public bool HasHostel { get; set; }
        public bool HasScholarship { get; set; }
        public override double CalculateSeverityIndex()
        {
            return Scholarship * Semester * 6;
        }
        public double GetSeverityIndex()
        {
            return CalculateSeverityIndex();
        }
        public Disease()
        {
        }
        public Disease(string name, string symptoms, string procedures, int age, double semester, double scholarship, bool hasHostel, bool hasScholarship)
        {
            Name = name;
            Symptoms = symptoms;
            Procedures = procedures;
            Age = age;
            Semester = semester;
            Scholarship = scholarship;
            HasHostel = hasHostel;
            HasScholarship = hasScholarship;
        }
    }
}
