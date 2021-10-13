using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reactive.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;
using Semver;
using WolvenManager.Installer.Models;

namespace WolvenManager.Installer.Services
{
    public class UpdateService : IUpdateService, IProgress<double>
    {
        #region fields

        private EUpdateChannel _updateChannel;
        private string[] _remoteUris;
        private string _assemblyName;
        private Action<FileInfo, bool> _updateAction;
        private Action<string, Func<bool, bool>> _askAction;

        #endregion

        public UpdateService()
        {
            _updateChannel = EUpdateChannel.Stable;
        }

        #region properties

        public bool IsUpdateAvailable { get; set; }
        public bool IsUpdateReadyToInstall { get; set; }
        public bool IsInitialized { get; set; }

        #endregion

        #region methods

        public void SetUpdateChannel(EUpdateChannel channel) => _updateChannel = channel;

        /// <summary>
        /// Initializes the Updatemanager
        /// </summary>
        /// <param name="updateUrls">full url to where the manifest is located</param>
        /// <param name="assemblyName">loaded assembly name to check the version against</param>
        /// <param name="updateAction">action to execute for managed installs</param>
        public void Init(string[] updateUrls, string assemblyName, Action<FileInfo, bool> updateAction, Action<string, Func<bool, bool>> askAction)
        {
            if (updateUrls.Any(x => string.IsNullOrEmpty(x)))
            {
                return;
            }

            _remoteUris = updateUrls;
            _assemblyName = assemblyName;
            _updateAction = updateAction;
            _askAction = askAction;

            IsInitialized = true;
        }

        private string GetUpdateUri() => _remoteUris[(int)_updateChannel];

        private Uri GetManifestUri() => new($"{GetUpdateUri().TrimEnd('/')}/{Constants.Manifest}");

        private static bool IsManaged() => File.Exists(Path.GetFullPath(Constants.ManagedRegistration));

        /// <summary>
        /// Public entry point to check for updates
        /// </summary>
        /// <returns></returns>
        public async Task CheckForUpdatesAsync()
        {
            var manifestUri = GetManifestUri();

            if (!IsInitialized)
            {
                return;
            }

            // ping
            try
            {
                var host = manifestUri.Host;
                var reply = new Ping().Send(host, 3000);
                if (reply.Status != IPStatus.Success)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }

            // check versions
            var http = new HttpClient();

            var manifestJson = await http.GetStringAsync(manifestUri);
            if (string.IsNullOrEmpty(manifestJson))
            {
                return;
            }
            var manifest = JsonSerializer.Deserialize<Manifest>(manifestJson);
            if (manifest == null)
            {
                return;
            }

            try
            {
                var v = new Version(manifest.Version);
                var pv = $"{v.Major}.{v.Minor}.{v.Build}";

                var latestVersion = SemVersion.Parse(pv);
                var myVersion = Helpers.GetAssemblyVersion(_assemblyName);

                if (latestVersion > myVersion)
                {
                    IsUpdateAvailable = true;

                    // check if portable
                    if (IsManaged())
                    {
                        await HandleUpdate(EIncludedFiles.Installer);
                    }
                    else
                    {
                        await HandleUpdate(EIncludedFiles.Portable);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }

            


            async Task HandleUpdate(EIncludedFiles type)
            {
                // check if update already downloaded before
                var physicalPath = new FileInfo(Path.Combine(Path.GetTempPath(), manifest.Get(type).Key));
                if (physicalPath.Exists)
                {
                    using (var mySha256 = SHA256.Create())
                    {
                        var hash = Helpers.HashFile(physicalPath, mySha256);
                        if (manifest.Get(type).Value.Equals(hash))
                        {
                            HandleUpdateFromFile(physicalPath);
                        }
                        else
                        {
                            // hash was not matching, redownload from remote
                            try
                            {
                                physicalPath.Delete();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }
                            finally
                            {
                                await DownloadUpdateAsync(manifest, type);
                            }
                        }
                    }
                }
                else
                {
                    await DownloadUpdateAsync(manifest, type);
                }
            }
        }

        private async Task DownloadUpdateAsync(Manifest manifest, EIncludedFiles type)
        {
            var latestVersion = manifest.Version;

            _askAction($"Update available. Would you like to update to the latest version {latestVersion}?",
                delegate(bool b)
                {
                    if (!b)
                    {
                        return true;
                    }

                    using (var wc = new WebClient())
                    {
                        var dlObservable = Observable.FromEventPattern<DownloadProgressChangedEventHandler, DownloadProgressChangedEventArgs>(
                            handler => wc.DownloadProgressChanged += handler,
                            handler => wc.DownloadProgressChanged -= handler);
                        var dlCompleteObservable = Observable.FromEventPattern<AsyncCompletedEventHandler, AsyncCompletedEventArgs>(
                            handler => wc.DownloadFileCompleted += handler,
                            handler => wc.DownloadFileCompleted -= handler);

                        _ = dlObservable
                            .Select(_ => (double)_.EventArgs.ProgressPercentage)
                            .Subscribe(d =>
                            {
                                Report(d / 100);
                            });

                        _ = dlCompleteObservable
                            .Select(_ => _.EventArgs)
                            .Subscribe(c =>
                            {
                                OnDownloadCompletedCallback(c, manifest, type);
                            });

                        var uri = new Uri($"{GetUpdateUri().TrimEnd('/')}/{manifest.Get(type).Key}");
                        var physicalPath = Path.Combine(Path.GetTempPath(), manifest.Get(type).Key);
                        wc.DownloadFileAsync(uri, physicalPath);
                    }
                    return true;
                });

            await Task.CompletedTask;
        }

        private void OnDownloadCompletedCallback(AsyncCompletedEventArgs e, Manifest manifest, EIncludedFiles type)
        {
            if (e.Cancelled)
            {
                Console.WriteLine("File download cancelled.");
            }

            if (e.Error != null)
            {
                Console.WriteLine(e.Error);
            }

            // check downloaded file
            var physicalPath = new FileInfo(Path.Combine(Path.GetTempPath(), manifest.Get(type).Key));
            if (physicalPath.Exists)
            {
                using (var mySha256 = SHA256.Create())
                {
                    var hash = Helpers.HashFile(physicalPath, mySha256);
                    if (manifest.Get(type).Value.Equals(hash))
                    {
                        HandleUpdateFromFile(physicalPath);
                    }
                    else
                    {
                        Console.WriteLine("Downloaded file does not match expected file.");
                    }
                }
            }
            else
            {
                Console.WriteLine("File download failed.");
            }
        }

        private void HandleUpdateFromFile(FileInfo path)
        {
            IsUpdateAvailable = false;
            IsUpdateReadyToInstall = true;

            // ask user to restart
            _askAction($"Update ready to install - restart?", delegate(bool b)
            {
                if (!b)
                {
                    return true;
                }

                _updateAction(path, IsManaged());

                return true;
            });
        }

        public void Report(double value)
        {

        }

        #endregion
    }
}
