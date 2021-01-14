using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.IO.Pipelines;
using System.Threading.Tasks;

namespace WebOnline.Applica.Common
{
    public class FileStorageSevice : IStorageSevice
    {
        private readonly string _userContextFile;
        private const string USER_CONTEXT_FODER_NAME = "user-context";
        public FileStorageSevice(IWebHostEnvironment webHost)
        {
            _userContextFile = Path.Combine(webHost.WebRootPath, USER_CONTEXT_FODER_NAME);
        }
        public async Task DeleteAync(string fileName)
        {
            var filepath = Path.Combine(_userContextFile, fileName);
            if (File.Exists(filepath))
            {
                await Task.Run(() => File.Delete(filepath));
            }
        }

        public string GetFileUrl(string Filename)
        {
            return $"/{USER_CONTEXT_FODER_NAME}/{Filename}";
        }

        public async Task SaveFileAync(Stream midiaBinarystream, string filename)
        {
            var filepath = Path.Combine(_userContextFile,filename);
            using var output = new FileStream(filepath, FileMode.Create);
            await midiaBinarystream.CopyToAsync(output);
        }
    }
}
