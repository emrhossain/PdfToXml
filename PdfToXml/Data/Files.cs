using System.ComponentModel.DataAnnotations;

namespace PdfToXml.Data
{
    public class Files
    {
        [Key]
        public int Id { get; set; }
        [Required]
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

    }
}
