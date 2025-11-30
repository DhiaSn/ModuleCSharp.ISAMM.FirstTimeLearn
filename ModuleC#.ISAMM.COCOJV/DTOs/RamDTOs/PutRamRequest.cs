namespace ModuleC_.ISAMM.COCOJV.DTOs.RamDTOs
{
    public class PutRamRequest
    {
        public Guid Id { get; set; }
        public int Size { get; set; }
        public int Frequency { get; set; }
        public string? Generation { get; set; }
    }
}
