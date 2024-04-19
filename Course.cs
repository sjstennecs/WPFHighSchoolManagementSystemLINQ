using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHighSchoolManagementSystemLINQ
{
    internal class Course
    {
        // properties
        private int _id;
        private string _name;
        private string _description;
        private List<Course> _prerequisites;
        private List<Student> _students;
        private Teacher _teacher;

        // getters and setters (we will add logic for the list of students and the list of prerequisites in the methods section)

        public int CourseId { get { return _id; } set { _id = value; } }
        public string Name { get { return _name;} set { _name = value; } }
        public string Description { get { return _description;} set { _description = value; } }
        public Teacher Teacher { get { return _teacher; } set { _teacher = value; } }

        // constructor
        public Course(int id, string name, string description, List<Course> prereqs, List<Student> students, Teacher teacher)
        {
            _id = id;
            _name = name;
            _description = description;
            _prerequisites = prereqs;
            _students = students;
            _teacher = teacher;
        }
        
        // methods
        // Start with methods concerning the Prereqs list
        public string PrintPrerequisites()
        {
            string outputString = $"Prerequisites for {this.Name}:";
            foreach (Course course in _prerequisites)
            {
                outputString += $"{course.Name} ";
            }
            return outputString;
        }

        public void AddPrerequisite(Course course)
        {
            this._prerequisites.Add(course);
        }

        public void RemovePrerequisiteByName(string targetName)
        {
            // perfect place for using LINQ
        }

        public void RemovePrerequisiteByID(int targetID)
        {
            // perfect place for using LINQ
        }
    }
}
