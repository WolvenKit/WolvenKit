using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// Normally the interface for CR2W files
    /// </summary>
    public interface IWolvenkitFile
    {
        string Cr2wFileName { get; set; }


        EFileReadErrorCodes Read(BinaryReader file);
        void Write(BinaryWriter writer);

        void SerializeToXml(Stream writer);
    }
}
