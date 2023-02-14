using PdfToXml.Data;

namespace PdfToXml.Services
{
    public interface IUploadedFilesService
    {
        public Task<List<UploadedFiles>> GetUploadedFiles();
        public Task<byte[]> GetUploadedPdfById(int Id);
        public Task<List<UploadedFiles>> GetUploadedFilesForUser(string userId);
        public Task<int> UploadPdfFile(UploadedFiles uploadedFilesObject);
        public Task<int> UploadOtherFiles(UploadedFiles uploadedFilesObject, int fileSerial);

    }
}
