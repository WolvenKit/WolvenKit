using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using CP77.Common.Tools.FNV1A;

namespace CP77.Common.Services
{
    public class HashService : IHashService
    {
        public Dictionary<ulong, string> Hashdict { get; set; } = new();

        private static readonly ILoggerService Logger = ServiceLocator.Default.ResolveType<ILoggerService>();
        private static readonly IAppSettingsService Appsettings = ServiceLocator.Default.ResolveType<IAppSettingsService>();

        private readonly HttpClient _client = new();

        //private const string ResourceUrl = "https://nyxmods.com/cp77/files/archivehashes.csv";
        private const string ResourceUrl = "https://graphicscore.dev/cyberpunk/cyberbot/data/loosehashes.txt";


        public async Task<bool> RefreshAsync()
        {
            if (!File.Exists(Appsettings.LooseHashesPath))
            {
                // redownload
                try
                {
                    if (File.Exists(Appsettings.ETagPath))
                        File.Delete(Appsettings.ETagPath);
                }
                catch (Exception)
                {
                    Logger.LogString($"Could not delete file {Appsettings.ETagPath}.", Logtype.Error);
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
            await using var fs = File.Create(Appsettings.ETagPath);
            await using var writer = new StreamWriter(fs);
            await writer.WriteLineAsync(etag);
        }

        private string GetLastEtag()
        {
            if (!File.Exists(Appsettings.ETagPath)) return null;

            var lines = File.ReadLines(Appsettings.ETagPath)
                .ToList();

            if (!lines.Any() || lines.Count > 1)
                return null;

            return lines.Single();
        }

        public void ReloadLocally()
        {
            Logger.LogString("Loading local filename hashes...", Logtype.Important);

            Stopwatch watch = new();
            watch.Restart();
            
            Hashdict.EnsureCapacity(1_500_000);
            
            using (var archive = ZipFile.Open(Appsettings.ArchiveHashesZipPath, ZipArchiveMode.Read, Encoding.UTF8))
            {
                var zipArchiveEntry = archive.GetEntry(Appsettings.ArchiveHashesPath);
                if (zipArchiveEntry != null)
                {
                    using var stream = zipArchiveEntry.Open();
                    AddHashesFromStream(Hashdict, stream);
                }
            }

            if (File.Exists(Appsettings.LooseHashesPath))
                AddHashesFromStream(Hashdict, File.OpenRead(Appsettings.LooseHashesPath));

            watch.Stop();

            Logger.LogString($"Loaded {Hashdict.Count} hashes in {watch.ElapsedMilliseconds}ms.", Logtype.Success);
        }

        private static void AddHashesFromStream(IDictionary<ulong, string> dictionary, Stream stream)
        {
            string line;
            using var sr = new StreamReader(stream, Encoding.UTF8);
            while ((line = sr.ReadLine()) != null)
            {
                dictionary[FNV1A64HashAlgorithm.HashString(line)] = line;
            }
        }
    }
}