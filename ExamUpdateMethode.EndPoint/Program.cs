using System;
using System.Collections.Generic;
using System.Linq;
using ExamUpdateMethode.Dal;

namespace ExamUpdateMethode.EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            ExamContext ctx = new ExamContext();
            Person person = ctx.people.FirstOrDefault();
            List<string> ls = new List<string> { "FulName", "PhoneNumber" };
            ctx.CustumUpdate<Person>(person, ls);


        }
    }
}
