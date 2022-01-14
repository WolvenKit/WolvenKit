using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool DumpEntityPackageAsJson(Stream entStream, FileInfo outfile)
        {
            var outpath = Path.ChangeExtension(outfile.FullName, ".json");
            var cr2w = _wolvenkitFileService.TryReadRed4File(entStream);
            if (cr2w == null)
            {
                return false;
            }
            if (cr2w.RootChunk is entEntityTemplate)
            {
                return DumpEntPackage(cr2w, entStream, outpath);
            }
            if (cr2w.RootChunk is appearanceAppearanceResource)
            {
                return DumpAppPackage(cr2w, entStream, outpath);
            }
            return false;
        }
        private bool DumpEntPackage(CR2WFile cr2w, Stream entStream, string outfile)
        {
            var blob = cr2w.RootChunk as entEntityTemplate;

            if (blob.CompiledData.Buffer.MemSize > 0)
            {
                var packageStream = new MemoryStream();
                packageStream.Write(blob.CompiledData.Buffer.GetBytes());

                var package = new CompiledPackage(_hashService);
                packageStream.Seek(0, SeekOrigin.Begin);
                package.Read(new BinaryReader(packageStream));
                var data = JsonConvert.SerializeObject(new RedFileDto(package), Formatting.Indented);
                File.WriteAllText(outfile, data);
                return true;
            }
            return false;
        }
        private bool DumpAppPackage(CR2WFile cr2w, Stream appStream, string outfile)
        {
            var blob = cr2w.RootChunk as appearanceAppearanceResource;

            var datas = new List<RedFileDto>();
            foreach (var appearance in blob.Appearances)
            {
                if (appearance.Chunk.CompiledData.Buffer.MemSize > 0)
                {
                    var packageStream = new MemoryStream();
                    packageStream.Write(appearance.Chunk.CompiledData.Buffer.GetBytes());

                    var package = new CompiledPackage(_hashService);
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
