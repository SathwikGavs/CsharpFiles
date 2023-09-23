using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB.Day2
{
    internal class Bill
    {

        public int PatientId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Cost { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public long Phone { get; set; }

        public override string ToString()
        {
            return                   $"        Patient Bill \n"+
                $"Patient ID:{this.PatientId}, " +
                $"Name:{Title}{FirstName} {LastName},\n" +
               $" Address:{Address}, City{City}, " +
               $"TotalCost:{Cost}, \n" +
               $" Phone:{Phone}, " +
               $"Country:{Country}, " +
               $"Zip:{PostalCode}, \n";

        }
    }

    internal class TestBill
    {
        public static void TestOne()
        {

            Bill firstPerson = new Bill();
            firstPerson.PatientId = 1;
            firstPerson.FirstName = "Sathwik";
            firstPerson.LastName = "Kumar";
            firstPerson.Title = "Mr.";
            firstPerson.Address = " Mainroad";
            firstPerson.City = " kodad";
            firstPerson.Country = " India";
            firstPerson.Phone = 990000;
            firstPerson.PostalCode = "132 456";
            firstPerson.Cost = " 5000$";
            String value = firstPerson.ToString();
            Console.WriteLine(value);





        }

    }



}


