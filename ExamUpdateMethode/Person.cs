using System;
using System.Collections.Generic;

namespace ExamUpdateMethode
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FulName { get; set; }
        public string   PhoneNumber { get; set; }
        public List<Student> Students { get; set; }

    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Address { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }

}
