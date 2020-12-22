using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Catel.IoC;
using WolvenKit.Common.Services;

namespace CP77Tools.Common.Services
{
    public class HashService : IHashService
    {
        private static readonly ILoggerService Logger = ServiceLocator.Default.ResolveType<ILoggerService>();
        
        private readonly HttpClient _client = new HttpClient();
        
        private const string ResourceUrl = "https://nyxmods.com/cp77/files/archivehashes.csv";
        private readonly string _resourcePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes.csv");
        private readonly string _eTagPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes-etag.txt");

        public async Task<bool> RefreshAsync()
        {
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

                Logger.LogString("Downloading latest Archive Hashes...");

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
            await using var fs = File.Create(_resourcePath);
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
    }
}
