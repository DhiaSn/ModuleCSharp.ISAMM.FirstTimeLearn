using ModuleC_.ISAMM.COCOJV.DTOs.PcGamerDTOs;
using ModuleC_.ISAMM.COCOJV.Entities;
using ModuleC_.ISAMM.COCOJV.Repositories;

namespace ModuleC_.ISAMM.COCOJV.Services
{
    public class PcGamerService
    {
        private readonly PcGamerRepository _pcGamerRepository;

        public PcGamerService()
        {
            _pcGamerRepository = new PcGamerRepository();
        }

        public List<GetAllPcGamerResponse> GetAll()
        {
            return _pcGamerRepository
                .GetAll()
                .Select(u => new GetAllPcGamerResponse(u))
                .ToList();
        }

        public GetPcGamerByIdResponse GetById(Guid id)
        {
            PcGamer pcGamer = _pcGamerRepository.GetById(id);
            if (pcGamer == null)
            {
                return null;
            }
            return new GetPcGamerByIdResponse(pcGamer);
        }


        public GetPcGamerByIdResponse Post(PostPcGamerRequest dto)
        {
            Guid pcGamerId = _pcGamerRepository.Post(new PcGamer
            {
                Brand = dto.Brand,
                CpuConfig = dto.CpuConfig,
                GpuConfig = dto.GpuConfig,
                Storage = dto.Storage,
                OS = dto.OS,
            });

            return GetById(pcGamerId);
        }

        public GetPcGamerByIdResponse Put(PutPcGamerRequest dto)
        {
            PcGamer pcGamer = _pcGamerRepository.GetById(dto.Id);

            if (pcGamer == null)
            {
                return null;
            }

            pcGamer.Brand = dto.Brand;
            pcGamer.CpuConfig = dto.CpuConfig;
            pcGamer.GpuConfig = dto.GpuConfig;
            pcGamer.Storage = dto.Storage;
            pcGamer.OS = dto.OS;

            _pcGamerRepository.Put(pcGamer);

            return GetById(pcGamer.Id);
        }

        public void Delete(Guid id)
        {
            _pcGamerRepository.Delete(id);
        }
    }
}
