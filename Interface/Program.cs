using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ILoger
    {
        void Log(string message);
            
    }
    class LogerXML : ILoger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + " XML");
        }
    }
    class LogerDataBase : ILoger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + " DataBase");
        }
    }
    class Person
    {
        private ILoger log;
        public Person(ILoger log)
        {
            this.log = log;
        }
        public string Name { get; set; }
        
        public void Log()
        {
            log.Log(Name);
        }
        public void ChangeLoger(ILoger log)
        {
            this.log = log;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(new LogerDataBase()) { Name = "Ivan"};
            person.Log();
            person.ChangeLoger(new LogerXML());
            person.Log();
            Person person2 = new Person(new LogerXML()) { Name = "Anna" };
            person2.Log();
            

            Console.ReadLine();
        }
    }
}
