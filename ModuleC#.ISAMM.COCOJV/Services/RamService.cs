using ModuleC_.ISAMM.COCOJV.DTOs.RamDTOs;
using ModuleC_.ISAMM.COCOJV.Entities;
using ModuleC_.ISAMM.COCOJV.Repositories;

namespace ModuleC_.ISAMM.COCOJV.Services
{
    public class RamService
    {
        private readonly RamRepository _ramRepository;

        public RamService()
        {
            _ramRepository = new RamRepository();
        }

        public List<GetAllRamResponse> GetAll()
        {
            return _ramRepository
                .GetAll()
                .Select(u => new GetAllRamResponse(u))
                .ToList();
        }

        public GetRamByIdResponse GetById(Guid id)
        {
            RAM ram = _ramRepository.GetById(id);
            if (ram == null)
            {
                return null;
            }
            return new GetRamByIdResponse(ram);
        }


        public GetRamByIdResponse Post(PostRamRequest dto)
        {
            Guid ramId = _ramRepository.Post(new RAM
            {
                Size = dto.Size,
                Frequency = dto.Frequency,
                Generation = dto.Generation,
            });

            return GetById(ramId);
        }

        public GetRamByIdResponse Put(PutRamRequest dto)
        {
            RAM ram = _ramRepository.GetById(dto.Id);

            if (ram == null)
            {
                return null;
            }

            ram.Size = dto.Size;
            ram.Frequency = dto.Frequency;
            ram.Generation = dto.Generation;

            _ramRepository.Put(ram);

            return GetById(ram.Id);
        }

        public void Delete(Guid id)
        {
            _ramRepository.Delete(id);
        }
    }
}
