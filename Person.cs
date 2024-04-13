using System;

namespace WPFHighSchoolManagementSystemLINQ
{
    internal class Person
    {
        private string _name;
        private int _age;
        private string _gender;

        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Gender { get { return _gender; } set { _name = value; } }


        public Person() {
            // Default constructor for person object
            Name = "John Doe";
            Age = 18;
            Gender = "Male";
        }

        // Overloaded constructor
        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string PersonToString()
        {
            return (Name + ", age " + Age + ", " + Gender);
        }
    }
}
