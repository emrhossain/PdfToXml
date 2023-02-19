using Microsoft.EntityFrameworkCore;
using PdfToXml.Data;

namespace PdfToXml.Services
{
    public class UserService : IUserService
    {
        private ApplicationDbContext _dbContext;

        public UserService( ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User?> GetUserById(string? Id)
        {
            var result = await _dbContext.Users.FindAsync(Id);

            if (result != null)
            {
                return result;
            }

            return null;
        }

    }
}
