using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model
{
    public interface IWolvenkitFile
    {
        string FileName { get; set; }


        int Read(BinaryReader file);
        void Write(BinaryWriter writer);

        void SerializeToXml(Stream writer);
    }
}
