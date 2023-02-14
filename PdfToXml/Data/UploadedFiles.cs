using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PdfToXml.Data
{
    public class UploadedFiles
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("UserId")]
        public string? UserId { get; set; }
        public byte[]? PdfFile { get; set; }
        public string? PdfFileName { get; set; }
        public byte[]? XmlFile { get; set; }
        public string? XmlFileName { get; set; }
        public byte[]? File1 { get; set; }
        public string? File1Name { get; set; }
        public byte[]? File2 { get; set;}
        public string? File2Name { get; set; }
        public DateTime UploadTime { get; set; }
        public virtual User? User { get; set; }

    }
}
