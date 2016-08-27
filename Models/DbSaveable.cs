using System;

namespace Models
{
    public interface IDbSaveable
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
    }
}
