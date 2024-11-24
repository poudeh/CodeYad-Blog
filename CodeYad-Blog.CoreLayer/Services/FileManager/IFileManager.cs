using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace CodeYad_Blog.CoreLayer.Services.FileManager
{
    public interface IFileManager
    {
        string SaveFile(IFormFile file, string SavePath);

    }

    public class FileManager:IFileManager
    {
        public string SaveFile(IFormFile file, string SavePath)
        {
            if (file == null)
                throw new Exception("File is null");
            var fileName = $"{Guid.NewGuid()}{file.FileName}";
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), SavePath.Replace("/" , "\\"));
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var fullpath = Path.Combine(folderPath + fileName);
            using var stream = new FileStream(fullpath, FileMode.Create);

            file.CopyTo(stream);

            return fileName;

        }
    }
}