using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.Modkit.RED4.Opus
{
    public class OpusTools
    {
        public static OpusInfo? GetOpusInfo(IArchiveManager archiveManager, bool useMod)
        {
            var opusInfo = archiveManager.GetGameFile(@"base\sound\soundbanks\sfx_container.opusinfo", false, useMod);
            if (opusInfo == null)
            {
                return null;
            }

            var infoStream = new MemoryStream();
            opusInfo.Extract(infoStream);
            return new OpusInfo(infoStream);
        }

        public static bool ExportOpusUsingHash(IArchiveManager archiveManager, List<uint> ids, bool useMod, DirectoryInfo rawOutDir)
        {
            var info = GetOpusInfo(archiveManager, useMod);
            if (info == null)
            {
                return false; 
            }
            
            for (uint i = 0; i < info.OpusCount; i++)
            {
                if (ids.Contains(info.OpusHashes[i]))
                {
                    var opusPak = archiveManager.GetGameFile(@$"base\sound\soundbanks\sfx_container_{info.PackIndices[i]}.opuspak", false, false);
                    if (opusPak == null)
                    {
                        continue;
                    }
                    
                    var ms = new MemoryStream();
                    opusPak.Extract(ms);
                    
                    info.WriteOpusFromPak(ms, rawOutDir, i);
                }
            }

            return true;
        }

        public static bool ImportWavs(IArchiveManager archiveManager, List<string> wavFiles, DirectoryInfo rawInDir, DirectoryInfo modOutDir)
        {
            if (wavFiles.Count < 1)
            {
                return false;
            }

            var info = GetOpusInfo(archiveManager, true);
            if (info == null)
            {
                return false;
            }

            var foundIds = wavFiles.Select(wav => Convert.ToUInt32(Path.GetFileNameWithoutExtension(wav))).ToList();

            var validIds = new List<uint>();
            foreach (var id in foundIds)
            {
                for (var e = 0; e < info.OpusCount; e++)
                {
                    if (info.OpusHashes[e] == id)
                    {
                        validIds.Add(id);
                        break;
                    }
                }
            }
            if (validIds.Count < 1)
            {
                return false;
            }

            var modDictionary = new Dictionary<int, Stream>();

            foreach (var id in validIds)
            {
                var name = Path.Combine(rawInDir.FullName, Convert.ToString(id) + ".opus");
                var proc = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusenc.exe"))
                {
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Arguments = $" \"{name.Replace("opus", "wav")}\" \"{name}\" --serial 42 --quiet --padding 0 --vbr --comp 10 --framesize 20 ",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                };
                using (var p = Process.Start(proc))
                {
                    p?.WaitForExit();
                }

                var procNew = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusdec.exe"))
                {
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Arguments = $" \"{name}\" \"{name.Replace("opus", "wav")}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                };
                using (var p = Process.Start(procNew))
                {
                    p?.WaitForExit();
                }

                var procN = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusenc.exe"))
                {
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Arguments = $" \"{name.Replace("opus", "wav")}\" \"{name}\" --serial 42 --quiet --padding 0 --vbr --comp 10 --framesize 20 ",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                };
                using (var p = Process.Start(procN))
                {
                    p?.WaitForExit();
                }

                if (!File.Exists(name))
                {
                    continue;
                }

                for (var e = 0; e < info.OpusCount; e++)
                {
                    if (info.OpusHashes[e] != id)
                    {
                        continue;
                    }

                    int pakIdx = info.PackIndices[e];

                    if (!modDictionary.TryGetValue(pakIdx, out var modStream))
                    {
                        var opusPak = archiveManager.GetGameFile(@$"base\sound\soundbanks\sfx_container_{pakIdx}.opuspak", false, true);
                        if (opusPak == null)
                        {
                            throw new Exception();
                        }

                        modStream = new MemoryStream();
                        opusPak.Extract(modStream);

                        modDictionary.Add(pakIdx, modStream);
                    }
                            
                    info.WriteOpusToPak(new MemoryStream(File.ReadAllBytes(name)), modDictionary[pakIdx], id, new MemoryStream(File.ReadAllBytes(name.Replace("opus", "wav"))));
                }
            }

            var writeInfo = false;

            foreach (var (pakIdx, stream) in modDictionary)
            {
                var pakName = @$"base\sound\soundbanks\sfx_container_{pakIdx}.opuspak";
                stream.Position = 0;

                using var fs = File.Create(Path.Combine(modOutDir.FullName, pakName));
                stream.CopyTo(fs);

                writeInfo = true;
            }
            
            if (writeInfo)
            {
                info.WriteOpusInfo(new DirectoryInfo(Path.Combine(modOutDir.FullName, "base\\sound\\soundbanks")));

                return true;
            }

            return false;
        }
    }
}
