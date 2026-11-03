using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.BLL
{
    public class FileService : IFileService
    {
        private static readonly string[] AllowedExtensions = { ".jpg", ".png", ".webp" };
        private const long MaxFileSize = 2 * 1024 * 1024; //2MB
        private static readonly string ImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
        public async Task<string?> UploadAsync(IFormFile file, CancellationToken cancellationToken = default)
        {
            if (file == null || file.Length == 0 || file.Length > MaxFileSize) return null;
            var extension = Path.GetExtension(file.FileName).ToLower();
            if (!AllowedExtensions.Contains(extension)) return null;

            var fileName = Guid.NewGuid().ToString() + extension; //grerwer123123.jpg
            Directory.CreateDirectory(ImagePath);
            var filePath = Path.Combine(ImagePath, fileName);

            await using var stream = File.Create(filePath);
            await file.CopyToAsync(stream, cancellationToken);

            return fileName;
        }
        public void Delete(string filename)
        {
            throw new NotImplementedException();
        }

        
    }
}
