using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOnline.Applica.Common
{
    public interface IStorageSevice
    {
        string GetFileUrl(string Filename);
        Task SaveFileAync(Stream midiaBinarystream, string filename);
        Task DeleteAync(string fileName);
    }
}
