using Microsoft.AspNetCore.Http;

namespace BowllyForever.Models.Home
{
    public class FileInputModel
    {
        public string Folder { get; set; }
        public IFormFile File { get; set; }
    }
}
