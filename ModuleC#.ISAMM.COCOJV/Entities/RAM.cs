namespace ModuleC_.ISAMM.COCOJV.Entities
{
    public class RAM : BaseEntity
    {
        public int Size { get; set; }
        public int Frequency { get; set; }
        public string? Generation { get; set; }

        public List<PcRam>? Pcs { get; set; }
    }
}
