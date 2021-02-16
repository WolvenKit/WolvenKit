using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;

namespace WolvenKit.Common.Services
{
    public interface IWolvenkitFileService
    {

        public IWolvenkitFile TryReadCr2WFile(Stream stream);
        public IWolvenkitFile TryReadCr2WFile(BinaryReader br);

        public IWolvenkitFile TryReadCr2WFileHeaders(Stream stream);
        public IWolvenkitFile TryReadCr2WFileHeaders(BinaryReader br);
    }
}
