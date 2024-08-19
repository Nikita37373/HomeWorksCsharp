﻿using System.Security.Cryptography.X509Certificates;

namespace _19_Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Class)]
    class CoderAttribute : Attribute
    {
        public string Name { get; set; } = "Nikita";
        public DateTime Date { get; set; } = DateTime.Now;
        public CoderAttribute(){}
        public CoderAttribute(string name , string date)
        {
            try
            {
                Name = name;
                Date = DateTime.Parse(date);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
        public override string ToString()
        {
            return $"Coder : {Name} , Date = {Date.ToShortDateString()}";
        }
    }
    [Obsolete, Serializable]
    [Coder]
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        [CoderAttribute]
        public Employee(){}
        [Coder("Sasha","2024-07-10")]
        public void IncreaseSalary(int sal)
        {
            Salary += sal; 
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Attributess for Class Employee");
            foreach (var item in typeof(Employee).GetCustomAttributes(true))
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Attributess for members of class Employee");
            foreach (var item in typeof(Employee).GetMembers())
            {
                Console.WriteLine("\t" + item.ToString());
                foreach (var attr in item.GetCustomAttributes(true))
                {
                    Console.WriteLine(attr);
                }
            }

        }
    }
}
