using WolvenKit.RED4.CR2W;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.CR2W.Types;
using System.IO;
using WolvenKit.Common.Oodle;
using WolvenKit.Modkit.RED4.Compiled;
using Newtonsoft.Json;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Tools;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool DumpEntityPackageAsJson(Stream entStream, FileInfo outfile)
        {
            string outpath = Path.ChangeExtension(outfile.FullName, ".json");
            var cr2w = _wolvenkitFileService.TryReadRED4File(entStream);
            if (cr2w == null || (!cr2w.Chunks.Select(_ => _.Data).OfType<entEntityTemplate>().Any() && !cr2w.Chunks.Select(_ => _.Data).OfType<appearanceAppearanceResource>().Any()))
            {
                return false;
            }
            if (cr2w.Chunks.Select(_ => _.Data).OfType<entEntityTemplate>().Any())
            {
                return DumpEntPackage(cr2w, entStream, outpath);
            }
            if (cr2w.Chunks.Select(_ => _.Data).OfType<appearanceAppearanceResource>().Any())
            {
                return DumpAppPackage(cr2w, entStream, outpath);
            }
            return false;
        }
        private bool DumpEntPackage(CR2WFile cr2w, Stream entStream, string outfile)
        {
            if (cr2w == null || !cr2w.Chunks.Select(_=>_.Data).OfType<entEntityTemplate>().Any())
            {
                return false;
            }
            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<entEntityTemplate>().First();

            if(blob.CompiledData.IsSerialized)
            {
                var bufferIdx = blob.CompiledData.Buffer.Value;
                var buffer = cr2w.Buffers[bufferIdx - 1];
                entStream.Seek(buffer.Offset, SeekOrigin.Begin);
                var packageStream = new MemoryStream();
                entStream.DecompressAndCopySegment(packageStream, buffer.DiskSize, buffer.MemSize);

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
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<appearanceAppearanceDefinition>().Any())
            {
                return false;
            }
            var blobs = cr2w.Chunks.Select(_ => _.Data).OfType<appearanceAppearanceDefinition>().ToList();
            List<RedFileDto> datas = new List<RedFileDto>();
            foreach(var blob in blobs)
            {
                if (blob.CompiledData.IsSerialized)
                {
                    var bufferIdx = blob.CompiledData.Buffer.Value;
                    var buffer = cr2w.Buffers[bufferIdx - 1];
                    appStream.Seek(buffer.Offset, SeekOrigin.Begin);
                    var packageStream = new MemoryStream();
                    appStream.DecompressAndCopySegment(packageStream, buffer.DiskSize, buffer.MemSize);

                    CompiledPackage package = new CompiledPackage(_hashService);
                    packageStream.Seek(0, SeekOrigin.Begin);
                    package.Read(new BinaryReader(packageStream));
                    datas.Add(new RedFileDto(package));
                }
            }
            if(datas.Count > 1)
            {
                var data = JsonConvert.SerializeObject(datas,Formatting.Indented);
                File.WriteAllText(outfile, data);
                return true;
            }
            return false;
        }

    }
}
