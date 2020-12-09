using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using CP77Tools.Model;
using WolvenKit.CR2W;

namespace CP77Tools
{
    public static partial class ConsoleFunctions
    {

        public static async Task<int> Cr2wTask(CR2WOptions options)
        {
            // initial checks
            var inputFileInfo = new FileInfo(options.path);
            if (!inputFileInfo.Exists)
                return 0;

            var f = File.ReadAllBytes(inputFileInfo.FullName);

            var cr2w = new CR2WFile();

            try
            {
                using var ms = new MemoryStream(f);
                using var br = new BinaryReader(ms);
                var (imports, _, buffers) = cr2w.ReadImportsAndBuffers(br);

                var obj = new Cr2wDumpObject();
                obj.Filename = inputFileInfo.FullName.ToString();

                if (options.strings || options.all)
                    obj.Stringdict = cr2w.StringDictionary;
                if (options.imports || options.all)
                    obj.Imports = imports;
                if (options.buffers || options.all)
                    obj.Buffers = buffers;
                if (options.chunks || options.all)
                    obj.Chunks = cr2w.Chunks;

                var joptions = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                var jsonstring = JsonSerializer.Serialize(obj, joptions);

                File.WriteAllText($"{inputFileInfo.FullName}.dump.json", jsonstring);
                Console.WriteLine($"Finished. Dump file written to {inputFileInfo.FullName}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return 1;
        }
    }
}