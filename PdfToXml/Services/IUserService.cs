using PdfToXml.Data;

namespace PdfToXml.Services
{
    public interface IUserService
    {
        public Task<User?> GetUserById(string? Id);
    }
}
