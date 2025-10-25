namespace ModuleC_.ISAMM.COCOJV.Entities
{
    public class PcGamer : BaseEntity
    {
        public PcGamer(Guid iD, string? brand, string? cpuConfig, string? gpuConfig, string? storage, OsType oS)
        {
            ID = iD;
            Brand = brand;
            CpuConfig = cpuConfig;
            GpuConfig = gpuConfig;
            Storage = storage;
            OS = oS;
        }

        public Guid ID { get; set; }
        public string? Brand { get; set; }
        public string? CpuConfig { get; set; }
        public string? GpuConfig { get; set; }
        public string? Storage { get; set; }
        public OsType OS { get; set; }

        public User? User { get; set; }

        public List<PcRam>? Rams { get; set; }
    }
}
