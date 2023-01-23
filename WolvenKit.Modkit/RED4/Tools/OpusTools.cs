using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;

namespace WolvenKit.Modkit.RED4.Opus
{
    public class OpusTools
    {
        private readonly ICyberGameArchive _soundBanks;
        private readonly DirectoryInfo _modFolder;
        private readonly DirectoryInfo _rawFolder;
        public OpusInfo Info { get; set; }
        private readonly bool _isModded;

        public OpusTools(string modFolder, string rawFolder, bool useMod = false) //audio_2_soundbanks.archive
        {
            var archiveManager = Locator.Current.GetService<IArchiveManager>().NotNull();

            _soundBanks = archiveManager.Archives.Items
                .Cast<Archive>()
                .First(_ => _.Name.Equals($"{EVanillaArchives.audio_2_soundbanks}.archive"));


            _modFolder = new DirectoryInfo(modFolder);
            _rawFolder = new DirectoryInfo(rawFolder);
            _isModded = useMod;
            if (!Directory.Exists(Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks")))
            {
                Directory.CreateDirectory(Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks"));
            }

            if (!Directory.Exists(_rawFolder.FullName))
            {
                Directory.CreateDirectory(_rawFolder.FullName);
            }

            // ???
            if (_isModded)
            {
                var infoFile = Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks\\sfx_container.opusinfo");
                if (File.Exists(infoFile))
                {
                    var ms = new MemoryStream(File.ReadAllBytes(infoFile));
                    var br = new BinaryReader(ms);
                    ms.Position = 0;

                    if (BitConverter.ToString(br.ReadBytes(3)) != "53-4E-44")
                    {
                        _isModded = false;
                    }
                    else
                    {
                        Info = new OpusInfo(ms);
                    }
                }
                else
                {
                    _isModded = false;
                }
            }

            if (!_isModded)
            {
                var hash = FNV1A64HashAlgorithm.HashString("base\\sound\\soundbanks\\sfx_container.opusinfo");
                var ms = new MemoryStream();
                if (_soundBanks.Files.ContainsKey(hash))
                {
                    ModTools.ExtractSingleToStream(_soundBanks, hash, ms);
                    Info = new OpusInfo(ms);
                }
                else
                {
                    throw new NotImplementedException();
                    //Info = new OpusInfo();
                }
            }

            ArgumentNullException.ThrowIfNull(Info, nameof(Info));
        }

        public bool ExportOpusUsingHash(uint opusHash)
        {
            if (!_isModded)
            {
                for (uint i = 0; i < Info.OpusCount; i++)
                {
                    if (Info.OpusHashes[i] == opusHash)
                    {
                        var containerHash = FNV1A64HashAlgorithm.HashString("base\\sound\\soundbanks\\sfx_container_" + Info.PackIndices[i] + ".opuspak");
                        var ms = new MemoryStream();
                        ModTools.ExtractSingleToStream(_soundBanks, containerHash, ms);
                        Info.WriteOpusFromPak(ms, _rawFolder, i);
                        return true;
                    }
                    if (Info.OpusCount == i + 1)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (uint i = 0; i < Info.OpusCount; i++)
                {
                    if (Info.OpusHashes[i] == opusHash)
                    {
                        var pakFile = Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks\\sfx_container_" + Info.PackIndices[i] + ".opuspak");
                        if (File.Exists(pakFile))
                        {
                            var ms = new MemoryStream(File.ReadAllBytes(pakFile));
                            Info.WriteOpusFromPak(ms, _rawFolder, i);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (Info.OpusCount == i + 1)
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool DumpAllOpusInfo()
        {
            var s = JsonSerializer.Serialize(Info, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Path.Combine(_rawFolder.FullName, "sfx_container.opusinfo.json"), s);
            return true;
        }

        public bool ImportWavs(params string[] wavFiles)
        {
            if (wavFiles.Length < 1)
            {
                return false;
            }

            var foundids = new List<uint>();
            foreach (var wav in wavFiles)
            {
                try
                {
                    var idddd = Convert.ToUInt32(Path.GetFileNameWithoutExtension(wav));
                    foundids.Add(idddd);
                }
                catch (Exception ex)
                {
                    Locator.Current.GetService<ILoggerService>().NotNull().Error(ex);
                }
            }

            var validids = new List<uint>();
            for (var i = 0; i < foundids.Count; i++)
            {
                for (var e = 0; e < Info.OpusCount; e++)
                {
                    if (Info.OpusHashes[e] == foundids[i])
                    {
                        validids.Add(foundids[i]);
                        break;
                    }
                }
            }
            if (validids.Count < 1)
            {
                return false;
            }

            var modStreams = new Stream[Info.PackIndices[Info.OpusCount - 1] + 1];

            for (var i = 0; i < validids.Count; i++)
            {
                var name = Path.Combine(_rawFolder.FullName, Convert.ToString(validids[i]) + ".opus");
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

                var procnew = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusdec.exe"))
                {
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Arguments = $" \"{name}\" \"{name.Replace("opus", "wav")}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                };
                using (var p = Process.Start(procnew))
                {
                    p?.WaitForExit();
                }

                var procn = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusenc.exe"))
                {
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Arguments = $" \"{name.Replace("opus", "wav")}\" \"{name}\" --serial 42 --quiet --padding 0 --vbr --comp 10 --framesize 20 ",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                };
                using (var p = Process.Start(procn))
                {
                    p?.WaitForExit();
                }

                if (File.Exists(name))
                {
                    for (var e = 0; e < Info.OpusCount; e++)
                    {
                        if (validids[i] == Info.OpusHashes[e])
                        {
                            int pakIdx = Info.PackIndices[e];
                            if (modStreams[pakIdx] == null)
                            {
                                var pakName = "base\\sound\\soundbanks\\sfx_container_" + pakIdx + ".opuspak";
                                if (_isModded && File.Exists(Path.Combine(_modFolder.FullName, pakName)))
                                {
                                    modStreams[pakIdx] = new MemoryStream(File.ReadAllBytes(Path.Combine(_modFolder.FullName, pakName)));
                                }
                                else
                                {
                                    var containerHash = FNV1A64HashAlgorithm.HashString(pakName);
                                    modStreams[pakIdx] = new MemoryStream();
                                    ModTools.ExtractSingleToStream(_soundBanks, containerHash, modStreams[pakIdx]);
                                }
                            }
                            Info.WriteOpusToPak(new MemoryStream(File.ReadAllBytes(name)), ref modStreams[pakIdx], validids[i], new MemoryStream(File.ReadAllBytes(name.Replace("opus", "wav"))));
                        }
                    }
                }
            }

            var writeinfo = false;
            for (var i = 0; i < modStreams.Length; i++)
            {
                if (modStreams[i] != null)
                {
                    var pakName = "base\\sound\\soundbanks\\sfx_container_" + i + ".opuspak";
                    var temp = modStreams[i];
                    temp.Position = 0;
                    var bytes = new byte[temp.Length];
                    temp.Read(bytes, 0, Convert.ToInt32(temp.Length));
                    File.WriteAllBytes(Path.Combine(_modFolder.FullName, pakName), bytes);
                    writeinfo = true;
                }
            }
            if (writeinfo)
            {
                Info.WriteOpusInfo(new DirectoryInfo(Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks")));

                return true;
            }

            return false;
        }
    }
}
