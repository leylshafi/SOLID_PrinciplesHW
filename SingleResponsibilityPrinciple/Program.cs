﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SRP_Before
{
    class Student
    {
        public string? Name { get; set; }
        public double Scholarship { get; set; }

        public Student(string name)
        {
            Name= name;
        }

        public string MarkAttendance()
        {
            return $"{Name} is here";
        }
    }
}


namespace SRP_After
{

    class AttendanceTracker
    {
        public Student? Student { get; set; }

        public AttendanceTracker(Student? student)
        {
            Student = student;
        }
        public string MarkAttendance()
        {
            return $"{Student} is here";
        }

    }

    class Student
    {
        public string? Name { get; set; }
        public double Scholarship { get; set; }

        public Student(string name)
        {
            Name = name;
        }

    }

}