using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        /// <summary>
        /// Converts a W2RC stream to text
        /// </summary>
        /// <param name="format"></param>
        /// <param name="instream"></param>
        /// <returns></returns>
        /// <exception cref="InvalidParsingException"></exception>
        /// <exception cref="SerializationException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string ConvertToText(ETextConvertFormat format, Stream instream)
        {
            var cr2w = _wolvenkitFileService.TryReadRed4File(instream);
            if (cr2w == null)
            {
                throw new InvalidParsingException("ConvertToText");
            }

            var json = "";
            var list = new List<object>
            {
                new Dictionary<string, object>() {
                { ":" + RedReflection.GetRedTypeFromCSType(cr2w.RootChunk.GetType()), new RedClassDto(cr2w.RootChunk) }
            }
            };

            var dto = new
            {
                WolvenKitVersion = "8.4.0",
                WKitJsonVersion = "0.0.1",
                Exported = DateTime.UtcNow.ToString("o"),
                Chunks = list
            };
            json = JsonConvert.SerializeObject(dto, Formatting.Indented);

            if (string.IsNullOrEmpty(json))
            {
                throw new SerializationException();
            }

            switch (format)
            {
                case ETextConvertFormat.json:
                    return json;
                case ETextConvertFormat.xml:
                {
                    var doc = JsonConvert.DeserializeXmlNode(json, RedFileDto.Magic);
                    using var tw = new StringWriter();
                    doc?.Save(tw);
                    return tw.ToString();
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }
        }

        /// <summary>
        /// Converts a given redengine file to a text format in a given outputDirectory
        /// </summary>
        /// <param name="format"></param>
        /// <param name="infile"></param>
        /// <param name="outputDirInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<bool> ConvertToAndWriteAsync(ETextConvertFormat format, string infile, DirectoryInfo outputDirInfo)
        {
            using var fs = new FileStream(infile, FileMode.Open, FileAccess.Read);
            try
            {
                var json = ConvertToText(format, fs);
                var outpath = Path.Combine(outputDirInfo.FullName, $"{Path.GetFileName(infile)}.{format}");

                switch (format)
                {
                    case ETextConvertFormat.json:
                        await File.WriteAllTextAsync(outpath, json);
                        break;
                    case ETextConvertFormat.xml:
                        var doc = JsonConvert.DeserializeXmlNode(json, RedFileDto.Magic);
                        doc?.Save(outpath);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(format), format, null);
                }

                _loggerService.Success($"Exported {infile} to {outpath}");

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
        public static CR2WFile ConvertFromJson(string json)
        {
            var newdto = JsonConvert.DeserializeObject<RedClassDto>(json);
            return newdto != null ? newdto.ToW2rc() : throw new InvalidParsingException("ConvertFromJson");
        }

        /// <summary>
        /// Creates a redengine file from a given textual representation and saves it to a given outputdirectory
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="outputDirInfo"></param>
        /// <exception cref="SerializationException"></exception>
        public bool ConvertFromAndWrite(FileInfo fileInfo, DirectoryInfo outputDirInfo)
        {
            var convertExtension = Path.GetExtension(fileInfo.Name).TrimStart('.').ToLower();
            if (!Enum.TryParse<ETextConvertFormat>(convertExtension, out var textConvertFormat))
            {
                throw new SerializationException();
            }

            var text = File.ReadAllText(fileInfo.FullName);

            // get extension from filename //TODO pass?
            var filenameWithoutConvertExtension = fileInfo.Name[..^convertExtension.Length];
            var ext = Path.GetExtension(filenameWithoutConvertExtension);
            var w2rc = textConvertFormat switch
            {
                ETextConvertFormat.json => ConvertFromJson(text),
                _ => throw new NotSupportedException(),
            };
            var outpath = Path.ChangeExtension(Path.Combine(outputDirInfo.FullName, fileInfo.Name), ext);

            using var fs2 = new FileStream(outpath, FileMode.Create, FileAccess.ReadWrite);
            using var writer = new CR2WWriter(fs2);
            writer.WriteFile(w2rc);

            return true;
        }
    }
}
