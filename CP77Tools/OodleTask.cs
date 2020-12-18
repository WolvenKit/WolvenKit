using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Catel.Collections;
using CP77Tools.Model;
using CP77Tools.Oodle;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.CR2W;

namespace CP77Tools
{

    public static partial class ConsoleFunctions
    {

        public static int OodleTask(string path, bool decompress)
        {
            if (string.IsNullOrEmpty(path))
                return 0;

            if (decompress)
            {
                var file = File.ReadAllBytes(path);
                using var ms = new MemoryStream(file) ;
                using var br = new BinaryReader(ms);

                

                var oodleCompression = br.ReadBytes(4);
                if (!(oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
                    throw new NotImplementedException();
                var size = br.ReadUInt32();

                var buffer = br.ReadBytes(file.Length - 8);

                byte[] unpacked = new byte[size];
                long unpackedSize = OodleLZ.Decompress(buffer, unpacked);

                using var msout = new MemoryStream();
                using var bw = new BinaryWriter(msout);
                bw.Write(unpacked);

                File.WriteAllBytes($"{path}.kark", msout.ToArray());
            }
            

            return 1;
        }
    }
}