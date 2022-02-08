using System;
using System.IO;
using WolvenKit.Modkit.RED4.Serialization;
using WolvenKit.RED4.TweakDB;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        /// <summary>
        /// Converts .tweak files in paths provided into TweakDB .bin files.
        /// </summary>
        /// <param name="path">Folder with .tweak files (defaults to current directory)</param>
        /// <param name="outpath">Folder to export .bin files (defaults to current directory)</param>
        /// <param name="keep">Keep existing .bin folder, if specified</param>
        public void TweakTask(string path, string outpath, bool keep)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = @".\";
            }
            try
            {
                if (string.IsNullOrEmpty(outpath))
                {
                    outpath = @".\";
                }
                else
                {
                    if (keep)
                    {
                        if (!Directory.Exists(outpath))
                        {
                            Directory.CreateDirectory(outpath);
                        }
                    }
                    else
                    {
                        if (Directory.Exists(outpath))
                        {
                            Directory.Delete(outpath, true);
                        }
                        Directory.CreateDirectory(outpath);
                    }
                }
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                return;
            }
            var tweakFiles = Directory.GetFiles(path, "*.tweak", SearchOption.AllDirectories);
            foreach (var f in tweakFiles)
            {
                var text = File.ReadAllText(f);
                var filename = Path.GetFileNameWithoutExtension(f) + ".bin";
                var outFile = Path.Combine(outpath, filename);

                try
                {
                    if (!Serialization.Deserialize(text, out var dict))
                    {
                        continue;
                    }
                    var db = new TweakDB();
                    //flats
                    foreach (var (key, value) in dict.Flats)
                    {
                        db.Add(key, value);
                    }
                    //groups
                    foreach (var (key, value) in dict.Groups)
                    {
                        db.Add(key, value);
                    }

                    db.Save(outFile);
                    _loggerService.Success($"Converted {f} to {outFile}.");
                }
                catch (Exception e)
                {
                    _loggerService.Error(e);
                    continue;
                }
            }
        }
    }
}
