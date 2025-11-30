using ModuleC_.ISAMM.COCOJV.DTOs.UserDTOs;
using ModuleC_.ISAMM.COCOJV.Entities;
using ModuleC_.ISAMM.COCOJV.Repositories;

namespace ModuleC_.ISAMM.COCOJV.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public List<GetAllUserResponse> GetAll()
        {
            return _userRepository
                .GetAll()
                .Select(u => new GetAllUserResponse(u))
                .ToList();
        }

        public GetUserByIdResponse GetById(Guid id)
        {
            User user = _userRepository.GetById(id);
            if (user == null)
            {
                return null;
            }
            return new GetUserByIdResponse(user);
        }


        public GetUserByIdResponse Post(PostUserRequest dto)
        {
            Guid userId = _userRepository.Post(new User
            {
                UserName = dto.UserName,
                Password = dto.Password,
                Age = dto.Age,
                Email = dto.Email,
                Region = dto.Region,
            });

            return GetById(userId);
        }

        public GetUserByIdResponse Put(PutUserRequest dto)
        {
            User user = _userRepository.GetById(dto.Id);

            if (user == null)
            {
                return null; 
            }

            user.Age = dto.Age;
            user.Email = dto.Email;
            user.Region = dto.Region;

            _userRepository.Put(user);

            return GetById(user.Id);
        }

        public void Delete(Guid id)
        {
            _userRepository.Delete(id);
        }
    }
}
