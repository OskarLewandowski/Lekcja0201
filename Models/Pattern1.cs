using System.ComponentModel.DataAnnotations;

namespace Lekcja0201.Models
{
    public class Pattern1
    {
        [Key]
        public int Id { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public string? ResultPart1 { get; set; }
        public string? ResultPart2 { get; set; }
        public string? ResultPart3 { get; set; }
    }
}
