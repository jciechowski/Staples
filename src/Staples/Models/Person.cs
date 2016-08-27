using Models;
namespace Staples.Models
{
    public class Person : IDbSaveable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
