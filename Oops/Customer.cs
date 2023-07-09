using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Oops
{
    //A class is customised data type, where data is represented by fields and behaviour using methods.
    public class Customer
    {
        string firstName, lastName;

        public Customer(): this("No FirstName provided","No LastName provided")
        {
        }
        public Customer(string firstName, string  lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void GetFullName()
        {
            Console.WriteLine($"{this.firstName} - {this.lastName}");
        }

        public int Calc(params int[] arr)
        {
            return 1;
        }

        //public int Calc(int a,int b)
        //{
        //    return 2;
        //}
    }
}
