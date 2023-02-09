using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PdfToXml.Data
{
    public class User: IdentityUser
    {
        [PersonalData]
        [MaxLength(64)]
        public string Name { get; set; }
        [PersonalData]
        [MaxLength(2000)]
        public string About { get; set; }

    }
}
