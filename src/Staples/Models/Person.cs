using Microsoft.AspNetCore.Mvc;
using Models;
using System;

namespace Staples.Models
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
