using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ValueAndReferenceType
{
    public enum Country
    {
        Ukraine,
        Russia
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
        

    class Program
    {
        static void Modify(Person person, int y, Country country)
        {
            person.Age = 20;
            person.Name = "Petr";
            y = 20;
            country = Country.Russia;
        }
        static void Modify2()
        {

        }
        static void Main(string[] args)
        {
            var person = new Person();
            dynamic person2 = new Person();
            person.Name = "Ivan";
            person.Age = 23;
            int x = 5;
            Country country = Country.Ukraine;
            Modify(person, x, country);
            Console.WriteLine("person.Name = {0}, person.Age = {1}, x = {2}, country = {3}", person.Name, person.Age, x, country);
            Console.ReadKey();
            // person.Age = 20, person.Name = "Petr", x = 5, country = Ukraine
            
            
        }
    }
}
