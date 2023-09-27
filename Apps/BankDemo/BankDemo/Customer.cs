using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankDemo
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }



        public Customer(string name, string address, string city, string country, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.Country = country;
            this.Phone = phone;
        }


    }
}
