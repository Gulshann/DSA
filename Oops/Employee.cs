using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Oops
{
    public interface Vehicle
    {
        void start();
        int run();
    }

    public interface Motor
    {
        void start();
        int run();
        
    }

    public class Car : Vehicle, Motor
    {
        int Vehicle.run()
        {
            return 1;
        }

        int Motor.run()
        {
            return 2;
        }

        public void start()
        {
            //throw new NotImplementedException();
        }
    }
    public class Employee
    {
        public readonly string name;
       public string FirstName;
       public string LastName;
       public string Email;
        protected string pro;
        internal string intt;
        string def;

        public Employee()
        {
            name = "gulshan";
            Console.WriteLine("This is the default constructor of base class.");
        }
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void PrintFullName()
        {
            try
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }
            catch (Exception ex)
            {

                throw;
            }
          

        }

    }

    public class FullTimeEmployee : Employee
    {

        public FullTimeEmployee(string firstName, string lastName):base(firstName, lastName)
        {
            Console.WriteLine("This is the overloaded constructor of child class.");
        }
       public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;
        public PartTimeEmployee():base()
        {

        }
    }

    public class man
    {
        public void calc()
        {
            Employee emp = new Employee();
            emp.Email = "";
            emp.intt = "";
        }
    }
}
