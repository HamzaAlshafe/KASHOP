using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.BLL
{
    public interface IFileService
    {
        Task<string?> UploadAsync(IFormFile file, CancellationToken cancellationToken = default);
        void Delete(string filename);
    }
}
