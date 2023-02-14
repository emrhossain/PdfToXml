using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PdfToXml.Data;
using System.Security.Claims;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace PdfToXml.Services
{
    public class UploadedFilesService : IUploadedFilesService
    {
        private ApplicationDbContext _dbContext;

        public UploadedFilesService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UploadedFiles>> GetUploadedFiles()
        {
            return await _dbContext.UploadedFiles.Include(s => s.User).ToListAsync();
        }

        public async Task<byte[]> GetUploadedPdfById(int Id)
        {
            var result = await _dbContext.UploadedFiles.FindAsync(Id);
            
            if (result != null)
            {
                return result.PdfFile;
            }

            return null;
        }

        public async Task<List<UploadedFiles>> GetUploadedFilesForUser(string userId)
        {
            return await _dbContext.UploadedFiles.Where(x => x.UserId == userId).ToListAsync();
        }


        public async Task<int> UploadOtherFiles(UploadedFiles uploadedFilesObject, int fileSerial)
        {
            var uploadedFileEntry = _dbContext.UploadedFiles.FirstOrDefault(item => item.Id == uploadedFilesObject.Id);
            if (uploadedFileEntry != null)
            {
                if (fileSerial == 1)
                {
                    uploadedFileEntry.File1 = uploadedFilesObject.File1;
                    uploadedFileEntry.File1Name = uploadedFilesObject.File1Name;
                }
                else
                {
                    uploadedFileEntry.File2 = uploadedFilesObject.File2;
                    uploadedFileEntry.File2Name = uploadedFilesObject.File2Name;
                }
            }
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> UploadPdfFile(UploadedFiles uploadedFilesObject)
        {
            uploadedFilesObject.UploadTime = DateTime.Now;
            _dbContext.Add(uploadedFilesObject);
            await _dbContext.SaveChangesAsync();
            return uploadedFilesObject.Id;
        }

    }
}
