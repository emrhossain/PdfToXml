using System.ComponentModel.DataAnnotations;

namespace PdfToXml.Data
{
    public class Files
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public string PdfUrl { get; set; }

    }
}
