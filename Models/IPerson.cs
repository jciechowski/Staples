namespace Models
{
    public interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
    }
}
