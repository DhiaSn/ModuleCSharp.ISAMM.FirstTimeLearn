using ModuleC_.ISAMM.COCOJV.Entities;

namespace ModuleC_.ISAMM.COCOJV.DTOs.PcGamerDTOs
{
    public class PostPcGamerRequest
    {
        public string? Brand { get; set; }
        public string? CpuConfig { get; set; }
        public string? GpuConfig { get; set; }
        public string? Storage { get; set; }
        public OsType OS { get; set; }
    }
}
