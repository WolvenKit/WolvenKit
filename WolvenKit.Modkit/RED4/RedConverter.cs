using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Interfaces.Core;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
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
            var list = new List<object>();
            foreach (var chunk in cr2w.Chunks)
            {
                list.Add(new Dictionary<string, object>() {
                    { ":" + chunk.RedType, new RedClassDto(chunk) }
                });
            }
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
        public bool ConvertToAndWrite(ETextConvertFormat format, string infile, DirectoryInfo outputDirInfo)
        {
            using var fs = new FileStream(infile, FileMode.Open, FileAccess.Read);
            try
            {
                var json = ConvertToText(format, fs);
                var outpath = Path.Combine(outputDirInfo.FullName, $"{Path.GetFileName(infile)}.{format.ToString()}");

                switch (format)
                {
                    case ETextConvertFormat.json:
                        File.WriteAllText(outpath, json);
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
        public CR2WFile ConvertFromJson(string json)
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
            var filenameWithoutConvertExtension = fileInfo.Name.Substring(0, fileInfo.Name.Length - convertExtension.Length);
            var ext = Path.GetExtension(filenameWithoutConvertExtension);

            CR2WFile w2rc;
            switch (textConvertFormat)
            {
                case ETextConvertFormat.json:
                    w2rc = ConvertFromJson(text);
                    break;
                case ETextConvertFormat.xml:
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var outpath = Path.ChangeExtension(Path.Combine(outputDirInfo.FullName, fileInfo.Name), ext);

            using var fs2 = new FileStream(outpath, FileMode.Create, FileAccess.ReadWrite);
            using var writer = new CR2WWriter(fs2);
            writer.WriteFile(w2rc);

            return true;
        }
    }
}
