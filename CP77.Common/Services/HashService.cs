using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using CP77.Common.Tools.FNV1A;
using CP77Tools.Common.Services;
using WolvenKit.Common.Services;

namespace CP77.Common.Services
{
    public class HashService : IHashService
    {
        private Dictionary<ulong, string> _hashdict = new();
        public Dictionary<ulong, string> Hashdict
        {
            get
            {
                return _hashdict;
                
            }
            set => _hashdict = value;
        }

        private static readonly ILoggerService Logger = ServiceLocator.Default.ResolveType<ILoggerService>();
        private static readonly IAppSettingsService Appsettings = ServiceLocator.Default.ResolveType<IAppSettingsService>();

        private readonly HttpClient _client = new();
        
        private const string ResourceUrl = "https://nyxmods.com/cp77/files/archivehashes.csv";
        
        private readonly string _eTagPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes-etag.txt");

        

        public async Task<bool> RefreshAsync()
        {
            if (!File.Exists(Appsettings.LooseHashesPath))
            {
                // redownload
                try
                {
                    if (File.Exists(_eTagPath))
                        File.Delete(_eTagPath);
                }
                catch (Exception)
                {
                    Logger.LogString($"Could not delete file {_eTagPath}.", Logtype.Error);
                }
            }


            var request = new HttpRequestMessage(HttpMethod.Get, ResourceUrl);

            var lastEtag = GetLastEtag();
            if (!string.IsNullOrEmpty(lastEtag))
            {
                request.Headers.Add("If-None-Match", $"{lastEtag}");
            }

            try
            {
                
                var response = await _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
                if (response.StatusCode == HttpStatusCode.NotModified)
                {
                    Logger.LogString("Already using the latest Archive Hashes", Logtype.Success);
                    return false;
                }

                var tags = response.Headers.GetValues("etag").ToList();
                if (tags.Count != 1)
                {
                    throw new FormatException("Response etag had unexpected format");
                }

                var serverEtag = tags.Single();
                if (!string.IsNullOrEmpty(lastEtag) && !string.IsNullOrEmpty(serverEtag) &&
                    string.Equals(lastEtag, serverEtag, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                Logger.LogString("Downloading latest Archive Hashes...", Logtype.Important);

                var stream = await response.Content.ReadAsStreamAsync();

                await WriteHashes(stream);
                await WriteEtag(serverEtag);

                Logger.LogString("Archive Hashes updated.", Logtype.Success);

                return true;
            }
            catch (HttpRequestException e)
            {
                Logger.LogString("Update Archive Hashes Failed - Server may not be available", Logtype.Error);
            }
            catch (FormatException)
            {
                Logger.LogString("Update Archive Hashes Failed - Server used unexpected eTag format", Logtype.Error);
            }
            catch (Exception)
            {
                Logger.LogString("Update Archive Hashes Failed - Unexpected Error", Logtype.Error);
            }

            return false;
        }

        private async Task WriteHashes(Stream source)
        {
            await using var fs = File.Create(Appsettings.LooseHashesPath);
            await source.CopyToAsync(fs);
        }

        private async Task WriteEtag(string etag)
        {
            await using var fs = File.Create(_eTagPath);
            await using var writer = new StreamWriter(fs);
            await writer.WriteLineAsync(etag);
        }

        private string GetLastEtag()
        {
            if (!File.Exists(_eTagPath)) return null;
            
            var lines = File.ReadLines(_eTagPath)
                .ToList();

            if (!lines.Any() || lines.Count > 1)
                return null;

            return lines.Single();
        }

        public async Task ReloadLocally()
        {
            Logger.LogString("Loading local filename hashes...", Logtype.Important);

            Stopwatch watch = new Stopwatch();
            watch.Restart();

            var hashDictionary = new ConcurrentDictionary<ulong, string>();

            // TODO: proper update handling
            try
            {
                File.Delete(Appsettings.ArchiveHashesPath);
            }
            catch (Exception)
            {
                Logger.LogString($"Could not delete file {Appsettings.ArchiveHashesPath}.", Logtype.Error);
            }

            ZipFile.ExtractToDirectory(Appsettings.ArchiveHashesZipPath, Appsettings.ResourcesPath);
            if (File.Exists(Appsettings.ArchiveHashesPath))
                Parallel.ForEach(File.ReadLines(Appsettings.ArchiveHashesPath), line =>
                {
                    // check line
                    if (line.Contains(','))
                        line = line.Split(',', StringSplitOptions.RemoveEmptyEntries).First();
                    if (string.IsNullOrEmpty(line))
                        return;
                    ulong hash = FNV1A64HashAlgorithm.HashString(line);
                    hashDictionary.AddOrUpdate(hash, line, (key, val) => val);
                });

            if (File.Exists(Appsettings.LooseHashesPath))
                Parallel.ForEach(File.ReadLines(Appsettings.LooseHashesPath), line =>
                {
                    // check line
                    if (line.Contains(','))
                        line = line.Split(',', StringSplitOptions.RemoveEmptyEntries).First();
                    if (string.IsNullOrEmpty(line))
                        return;
                    ulong hash = FNV1A64HashAlgorithm.HashString(line);
                    hashDictionary.AddOrUpdate(hash, line, (key, val) => val);
                });

            Hashdict = hashDictionary.ToDictionary(
                entry => entry.Key,
                entry => entry.Value);

            watch.Stop();

            Logger.LogString($"Loaded {hashDictionary.Count} hashes in {watch.ElapsedMilliseconds}ms.", Logtype.Success);
        }
    }
}
