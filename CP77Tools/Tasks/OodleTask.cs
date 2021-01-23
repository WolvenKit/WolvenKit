using System;
using System.IO;
using System.Linq;
using WolvenKit.Common.Oodle;

namespace CP77Tools.Tasks
{

    public static partial class ConsoleFunctions
    {

        public static int OodleTask(string path, string outpath, bool decompress)
        {
            if (string.IsNullOrEmpty(path))
                return 0;

            if (string.IsNullOrEmpty(outpath)) { outpath = path; }

            if (decompress)
            {
                var file = File.ReadAllBytes(path);
                using var ms = new MemoryStream(file);
                using var br = new BinaryReader(ms);

                var oodleCompression = br.ReadBytes(4);
                if (!(oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
                    throw new NotImplementedException();
                var size = br.ReadUInt32();

                var buffer = br.ReadBytes(file.Length - 8);

                byte[] unpacked = new byte[size];
                long unpackedSize = OodleHelper.Decompress(buffer, unpacked);

                using var msout = new MemoryStream();
                using var bw = new BinaryWriter(msout);
                bw.Write(unpacked);

                File.WriteAllBytes($"{outpath}.kark", msout.ToArray());
            }


            return 1;
        }
    }
}