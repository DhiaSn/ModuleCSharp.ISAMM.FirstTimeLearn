using ModuleC_.ISAMM.COCOJV.Entities;

namespace ModuleC_.ISAMM.COCOJV.DTOs.UserDTOs
{
    public class GetAllUserResponse
    {
        public GetAllUserResponse(User user)
        {
            Id = user.Id;
            UserName = user.UserName;
            Age = user.Age;
            Email = user.Email;
        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
