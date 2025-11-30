namespace ModuleC_.ISAMM.COCOJV.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            
        }
        public User(string userName, string password, int age, string? email, string? region)
        {
            UserName = userName;
            Password = password;
            Age = age;
            Email = email;
            Region = region;
        }

        public required string UserName { get; set; }
        public required string Password { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? Region { get; set; }

        public List<PcGamer>? PCs { get; set; }
    }
}
