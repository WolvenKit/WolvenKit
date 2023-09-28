using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        /// <summary>
        /// Converts a W2RC file to json
        /// </summary>
        /// <param name="format"></param>
        /// <param name="infile"></param>
        /// <param name="skipHeader"></param>
        /// <returns></returns>
        /// <exception cref="InvalidParsingException"></exception>
        /// <exception cref="SerializationException"></exception>
        public async Task<string> ConvertToJsonAsync(string infile, bool skipHeader = false)
        {
            using var instream = new FileStream(infile, FileMode.Open, FileAccess.Read);

            if (!_parserService.TryReadRed4File(instream, out var cr2w))
            {
                throw new InvalidParsingException("ConvertToText");
            }

            cr2w.MetaData.FileName = infile;

            var dto = new RedFileDto(cr2w);

            // serialize
            using var stream = new MemoryStream();
            await RedJsonSerializer.SerializeAsync(stream, dto, new RedJsonSerializerOptions {SkipHeader = skipHeader});

            // convert to text
            stream.Seek(0, SeekOrigin.Begin);
            using var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();

            if (string.IsNullOrEmpty(json))
            {
                throw new SerializationException();
            }
            return json;
        }

        /// <summary>
        /// Converts a W2RC file to UTF-8 encoded JSON text and write it to the <see cref="System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="format"></param>
        /// <param name="stream"></param>
        /// <param name="skipHeader"></param>
        /// <returns></returns>
        /// <exception cref="InvalidParsingException"></exception>
        public async Task ConvertToJsonAsync(Stream stream, string infile, bool skipHeader = false)
        {
            using var instream = new FileStream(infile, FileMode.Open, FileAccess.Read);

            if (!_parserService.TryReadRed4File(instream, out var cr2w))
            {
                throw new InvalidParsingException("ConvertToText");
            }

            cr2w.MetaData.FileName = infile;

            var dto = new RedFileDto(cr2w);

            // serialize
            await RedJsonSerializer.SerializeAsync(stream, dto, new RedJsonSerializerOptions { SkipHeader = skipHeader });
        }

        /// <summary>
        /// Converts a given redengine file to a text format in a given outputDirectory
        /// </summary>
        /// <param name="format"></param>
        /// <param name="infile"></param>
        /// <param name="outputDirInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<bool> ConvertToJsonAndWriteAsync(string infile, DirectoryInfo outputDirInfo)
        {
            try
            {
                var outpath = Path.Combine(outputDirInfo.FullName, $"{Path.GetFileName(infile)}.json");
                using var fileStream = File.Open(outpath, FileMode.Create, FileAccess.Write);
                await ConvertToJsonAsync(fileStream, infile);

                _loggerService.Success($"Converted {infile} to {outpath}");

                return true;
            }
            catch (InvalidParsingException ie)
            {
                _loggerService.Error(ie);
            }
            catch (SerializationException se)
            {
                _loggerService.Error(se);
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }

            return false;
        }

        /// <summary>
        /// Converts a json string to W2RC file
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        /// <exception cref="InvalidParsingException"></exception>
        public CR2WFile? ConvertFromJson(string json)
        {
            _hookService.OnImportFromJson(ref json);

            var dto = RedJsonSerializer.Deserialize<RedFileDto>(json);

            return dto is null ? null : dto.Data ?? null;
        }

        /// <summary>
        /// Creates a redengine file from a given textual representation and saves it to a given outputdirectory
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="outputDirInfo"></param>
        /// <exception cref="SerializationException"></exception>
        public async Task<bool> ConvertFromJsonAndWriteAsync(FileInfo fileInfo, DirectoryInfo outputDirInfo)
        {
            var convertExtension = Path.GetExtension(fileInfo.Name).TrimStart('.').ToLower();
            if (!Enum.TryParse<ETextConvertFormat>(convertExtension, out var textConvertFormat))
            {
                throw new SerializationException();
            }

            var text = await File.ReadAllTextAsync(fileInfo.FullName);

            // get extension from filename //TODO pass?
            var filenameWithoutConvertExtension = fileInfo.Name[..^convertExtension.Length /*+ 1*/];
            var ext = Path.GetExtension(filenameWithoutConvertExtension);
            var w2rc = textConvertFormat switch
            {
                ETextConvertFormat.json => ConvertFromJson(text),
                _ => throw new NotSupportedException(),
            };
            if (w2rc is null)
            {
                return false;
            }

            var outpath = Path.ChangeExtension(Path.Combine(outputDirInfo.FullName, fileInfo.Name), ext);

            using var fs2 = new FileStream(outpath, FileMode.Create, FileAccess.ReadWrite);
            using var writer = new CR2WWriter(fs2) { LoggerService = _loggerService };
            writer.WriteFile(w2rc);

            _loggerService.Success($"Imported {fileInfo.Name} to {outpath}");

            return true;
        }
    }
}
