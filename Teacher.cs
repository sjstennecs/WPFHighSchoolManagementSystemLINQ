using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHighSchoolManagementSystemLINQ
{
    internal class Teacher : Person
    {
        // properties
        private int _salary;
        private DateTime _csd; // contract start date
        private DateTime _ced; // contract end date

        public int Salary {  get { return _salary; } set {  _salary = value; } }
        public DateTime StartDate { get { return _csd; } set { _csd = value; } }
        public DateTime EndDate { get { return _ced; } set { _ced = value; } }

        // constructors
        public Teacher(string name, int age, string gender, int sal, string startdate, string enddate):base(name,age,gender)
        {

        }

        // methods
        public int YearsLeftAtSchool()
        {
            return EndDate.Year - StartDate.Year;
        }
    }
}
