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

        // --> TO DO: 
        /*
         * POST 
         * PUT
         * Delete
         */
        // ----------------
    }
}
