using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool DumpEntityPackageAsJson(Stream entStream, FileInfo outfile)
        {
            string outpath = Path.ChangeExtension(outfile.FullName, ".json");
            var cr2w = _wolvenkitFileService.TryReadRed4File(entStream);
            if (cr2w == null || (!cr2w.Chunks.OfType<entEntityTemplate>().Any() && !cr2w.Chunks.OfType<appearanceAppearanceResource>().Any()))
            {
                return false;
            }
            if (cr2w.Chunks.OfType<entEntityTemplate>().Any())
            {
                return DumpEntPackage(cr2w, entStream, outpath);
            }
            if (cr2w.Chunks.OfType<appearanceAppearanceResource>().Any())
            {
                return DumpAppPackage(cr2w, entStream, outpath);
            }
            return false;
        }
        private bool DumpEntPackage(CR2WFile cr2w, Stream entStream, string outfile)
        {
            if (cr2w == null || !cr2w.Chunks.OfType<entEntityTemplate>().Any())
            {
                return false;
            }
            var blob = cr2w.Chunks.OfType<entEntityTemplate>().First();

            if (blob.CompiledData.Buffer.Length > 0)
            {
                var bufferIdx = blob.CompiledData.Pointer;
                var buffer = cr2w.Buffers[bufferIdx - 1];

                var unpacked = new byte[buffer.MemSize];
                _ = OodleHelper.Decompress(buffer.Data, unpacked);
                var packageStream = new MemoryStream();
                packageStream.Write(unpacked);

                CompiledPackage package = new CompiledPackage(_hashService);
                packageStream.Seek(0, SeekOrigin.Begin);
                package.Read(new BinaryReader(packageStream));
                string data = JsonConvert.SerializeObject(new RedFileDto(package), Formatting.Indented);
                File.WriteAllText(outfile, data);
                return true;
            }
            return false;
        }
        private bool DumpAppPackage(CR2WFile cr2w, Stream appStream, string outfile)
        {
            if (cr2w == null || !cr2w.Chunks.OfType<appearanceAppearanceDefinition>().Any())
            {
                return false;
            }
            var blobs = cr2w.Chunks.OfType<appearanceAppearanceDefinition>().ToList();
            List<RedFileDto> datas = new List<RedFileDto>();
            foreach (var blob in blobs)
            {
                if (blob.CompiledData.Buffer.Length > 0)
                {
                    var bufferIdx = blob.CompiledData.Pointer;
                    var buffer = cr2w.Buffers[bufferIdx - 1];

                    var unpacked = new byte[buffer.MemSize];
                    _ = OodleHelper.Decompress(buffer.Data, unpacked);
                    var packageStream = new MemoryStream();
                    packageStream.Write(unpacked);

                    CompiledPackage package = new CompiledPackage(_hashService);
                    packageStream.Seek(0, SeekOrigin.Begin);
                    package.Read(new BinaryReader(packageStream));
                    datas.Add(new RedFileDto(package));
                }
            }
            if (datas.Count > 1)
            {
                var data = JsonConvert.SerializeObject(datas, Formatting.Indented);
                File.WriteAllText(outfile, data);
                return true;
            }
            return false;
        }

    }
}
