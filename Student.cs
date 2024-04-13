namespace WPFHighSchoolManagementSystemLINQ
{
    internal class Student : Person // Student should extend the Person class to promote OOP
    {
        // properties
        // What sets our student apart from the Person parent class?
        private double _gpa;
        private bool _probationary;
        private int _yearGroup;

        public double Gpa { get { return _gpa; } set { _gpa = value; } }
        public bool ProbationaryStudent { get { return _probationary; } set { _probationary = value; } }
        public int YearGroup { get { return _yearGroup; } set { _yearGroup = value; } }

        // constructors
        public Student (string name, int age, string gender, double gpa, bool prob, int year):base (name, age, gender)
        {
            // base will use the parent class Parent to define those fields.
            Gpa = gpa;
            ProbationaryStudent = prob;
            YearGroup = year;
        }

        // methods
        public string StudentToString()
        {
            string rtnString = string.Format("{0}, age {1}, gender {2}, is currently a {3} with a GPA of {4:0.00} and is currently {5}.", Name, Age, Gender, GetYearFromYearNum(), Gpa, ProbationaryString());
            return rtnString;
        }

        private string GetYearFromYearNum()
        {
            switch(YearGroup)
            {
                case 1:
                    return "Freshman";
                case 2:
                    return "Sophomore";
                case 3:
                    return "Junior";
                case 4:
                    return "Senior";
                default:
                    return "Invalid year group";
            }
        }

        private string ProbationaryString()
        {
            if (ProbationaryStudent)
            {
                return "not on track to graduate on time";
            }
            else
            {
                return "on track to graduate on time";
            }
        }
    }
}
