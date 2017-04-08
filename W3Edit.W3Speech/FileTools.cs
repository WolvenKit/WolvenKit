using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using W3Edit.W3Strings;

namespace W3Edit.W3Speech
{
    static class FileTools
    {
        /// <summary>
        /// Parse all files in the directory path to input pairs.
        /// </summary>
        /// <param name="language">Language information about the files.</param>
        /// <param name="path">Path to the directory that holds all the wem and cr2w files.</param>
        /// <returns>Information about all the wem and cr2w pairs found in the directory.</returns>
        /// <exception cref="Exception">Something happened.</exception>
        public static IEnumerable<WemCr2wInputPair> CollectInputPairs(W3Language language, String path)
        {
            var dot = new char[] { '.' };
            var ob = new char[] { '[' };
            var cb = new char[] { ']' };
            return Directory
                .GetFiles(path)
                .Where(file => file.EndsWith(".wem") || file.EndsWith(".cr2w"))
                .GroupBy(file => Path.GetFileName(file).Split(dot).First().Split(ob).First())
                .Select(paths =>
                {
                    var neutral_id = new LanguageNeutralID((UInt32)long.Parse(paths.Key));
                    var specific_id = LanguageTools.Convert(neutral_id, language);
                    var wem_path = paths.First(p => p.EndsWith(".wem"));
                    var cr2w_path = paths.First(p => p.EndsWith(".cr2w"));
                    var wem = new FileInfo(wem_path);
                    var cr2w = new FileInfo(cr2w_path);
                    var duration = float.Parse(wem_path.Split(ob).Last().Split(cb).First(), CultureInfo.InvariantCulture.NumberFormat);
                    return new WemCr2wInputPair(specific_id, 0, () => wem.OpenRead(), (UInt32)wem.Length, duration, () => cr2w.OpenRead(), (UInt32)cr2w.Length);
                })
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Packages up all the files found in directory into the new w3speech file output_file.
        /// Uses 'CPSW' for id and 163 for version.
        /// </summary>
        /// <param name="language">Language information about the files.</param>
        /// <param name="directory">Path to the directory that holds all the wem and cr2w files.</param>
        /// <param name="output_file">Path to the new w3speech file that should be created.</param>
        /// <exception cref="Exception">Something happened.</exception>
        public static void PackDirectory(W3Language language, String directory, String output_file)
        {
            PackDirectory(language, directory, output_file, "CPSW", 163);
        }

        /// <summary>
        /// Packages up all the files found in directory into the new w3speech file output_file.
        /// </summary>
        /// <param name="id">Usually 'CPSW'.</param>
        /// <param name="version">Usually 163 or 162.</param>
        /// <param name="language">Language information about the files.</param>
        /// <param name="directory">Path to the directory that holds all the wem and cr2w files.</param>
        /// <param name="output_file">Path to the new w3speech file that should be created.</param>
        /// <exception cref="Exception">Something happened.</exception>
        public static void PackDirectory(W3Language language, String directory, String output_file, String id, UInt32 version)
        {
            var inputs = CollectInputPairs(language, directory);
            var output_stream = new BinaryWriter(new FileStream(output_file, FileMode.Create));
            Coder.Encode(id, version, inputs, language.Key, output_stream);
            output_stream.Close();
        }

        /// <summary>
        /// Unpacks the w3speech file into the directory using the list of default languages.
        /// </summary>
        /// <param name="directory">The directory where the new wem and cr2w files will be unpacked into.</param>
        /// <param name="w3speech_file">The w3speech file to unpack.</param>
        /// <exception cref="Exception">Something happened.</exception>
        public static void UnpackW3SpeechFile(String directory, String w3speech_file)
        {
            UnpackW3SpeechFile(directory, w3speech_file, W3Language.languages);
        }

        /// <summary>
        /// Unpacks the w3speech file into the directory.
        /// </summary>
        /// <param name="directory">The directory where the new wem and cr2w files will be unpacked into.</param>
        /// <param name="w3speech_file">The w3speech file to unpack.</param>
        /// <param name="languages">Information about the known languages. The right one will be selected automatically.</param>
        /// <exception cref="Exception">Something happened.</exception>
        public static void UnpackW3SpeechFile(String directory, String w3speech_file, IEnumerable<W3Language> languages)
        {
            var input = new BinaryReader(new FileStream(w3speech_file, FileMode.Open));
            var info = Coder.Decode(input);
            var language = languages.First(lang => lang.Key.value == info.language_key.value);
            var dir = directory.EndsWith("\\") ? directory : directory + "\\";
            info.item_infos.ToList().ForEach(item =>
            {
                var neutral_id = LanguageTools.Convert(item.id, language);
                var wem_file_name = neutral_id.value.ToString("D10") + "[" + item.duration.ToString(CultureInfo.InvariantCulture) + "].wem";
                var wem_output = new BinaryWriter(new FileStream(dir + wem_file_name, FileMode.Create));
                input.BaseStream.Seek((int)item.wem_offs, SeekOrigin.Begin);
                UInt64 i = 0;
                while (i < item.wem_size)
                {
                    wem_output.Write(input.ReadByte());
                    i += 1;
                }
                wem_output.Close();

                var cr2w_file_name = neutral_id.value.ToString("D10") + ".cr2w";
                var cr2w_output = new BinaryWriter(new FileStream(dir + cr2w_file_name, FileMode.Create));
                input.BaseStream.Seek((int)item.cr2w_offs, SeekOrigin.Begin);
                i = 0;
                while (i < item.cr2w_size)
                {
                    cr2w_output.Write(input.ReadByte());
                    i += 1;
                }
                cr2w_output.Close();
            });
            input.Close();
        }
    }
}
