using ModuleC_.ISAMM.COCOJV.Entities;

namespace ModuleC_.ISAMM.COCOJV.DTOs.PcGamerDTOs
{
    public class GetPcGamerByIdResponse
    {
        public GetPcGamerByIdResponse(PcGamer pcGamer)
        {
            Id = pcGamer.Id;
            Brand = pcGamer.Brand;
            CpuConfig = pcGamer.CpuConfig;
            GpuConfig = pcGamer.GpuConfig;
            Storage = pcGamer.Storage;
            OS = pcGamer.OS;
        }


        public Guid Id { get; set; }
        public string? Brand { get; set; }
        public string? CpuConfig { get; set; }
        public string? GpuConfig { get; set; }
        public string? Storage { get; set; }
        public OsType OS { get; set; }
    }
}
