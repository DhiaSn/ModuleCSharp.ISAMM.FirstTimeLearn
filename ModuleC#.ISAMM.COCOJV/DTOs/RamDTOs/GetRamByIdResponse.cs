using ModuleC_.ISAMM.COCOJV.Entities;

namespace ModuleC_.ISAMM.COCOJV.DTOs.RamDTOs
{
    public class GetRamByIdResponse
    {
        public GetRamByIdResponse(RAM ram)
        {
            Id = ram.Id;
            Size = ram.Size;
            Frequency = ram.Frequency;
            Generation = ram.Generation;
        }
        public Guid Id { get; set; }
        public int Size { get; set; }
        public int Frequency { get; set; }
        public string? Generation { get; set; }
    }
}
