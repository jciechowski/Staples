namespace Models
{
    public class DbSaveable : IDbSaveable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }

    public interface IDbSaveable
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
    }
}
