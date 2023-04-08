using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercise
{
    public class Customer
    {
        private List<Customer> _customer;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public string? City { get; set; }
        public int Income { get; set; }
        public bool IsMarried { get; set; }
        public bool IsWorking { get; set; }
    }


    public class CustomerList
    {
        private readonly List<Customer> _customerList;

        public CustomerList()
        {
            _customerList = new()
            {
                    new Customer()
                    {
                        Age = 23, City = "ankara", Income = 12000, IsMarried = false, IsWorking = true, Name = "Erkan",
                        Surname = "Sadık"
                    },
                    new Customer()
                    {
                        Age = 32, City = "tekirdag", Income = 15000, IsMarried = true, IsWorking = true, Name = "nazlı",
                        Surname = "bar"
                    },
                    new Customer()
                    {
                        Age = 65, City = "ankara", Income = 6000, IsMarried = true, IsWorking = false, Name = "ender",
                        Surname = "yar"
                    },
                    new Customer()
                    {
                        Age = 21, City = "konya", Income = 12000, IsMarried = false, IsWorking = true, Name = "irem",
                        Surname = "Sadık"
                    },
                    new Customer()
                    {
                        Age = 25, City = "ankara", Income = 10000, IsMarried = true, IsWorking = true, Name = "dilara",
                        Surname = "kor"
                    },
                    new Customer()
                    {
                        Age = 35, City = "istanbul", Income = 10000, IsMarried = false, IsWorking = true,
                        Name = "bekir", Surname = "bak"
                    },
                    new Customer()
                    {
                        Age = 40, City = "adana", Income = 11000, IsMarried = true, IsWorking = true, Name = "selin",
                        Surname = "sal"
                    },
                    new Customer()
                    {
                        Age = 45, City = "izmir", Income = 10000, IsMarried = true, IsWorking = true, Name = "murat",
                        Surname = "sor"
                    },
                    new Customer()
                    {
                        Age = 29, City = "istanbul", Income = 18000, IsMarried = false, IsWorking = true,
                        Name = "necmi", Surname = "dik"
                    },
                    new Customer()
                    {
                        Age = 26, City = "yozgat", Income = 9000, IsMarried = false, IsWorking = false, Name = "eda",
                        Surname = "sök"
                    }
            };
        }

        public List<Customer> GetCustomers() => _customerList;
    }
}
