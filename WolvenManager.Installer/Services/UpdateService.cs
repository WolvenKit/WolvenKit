using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reactive.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;
using WolvenKit.Common.Services;
using WolvenKit.Core;
using WolvenKit.Core.Services;
using WolvenManager.Installer.Models;

namespace WolvenManager.Installer.Services
{
    public class UpdateService : IUpdateService
    {
        #region fields

        private readonly INotificationService _notificationService;
        private readonly ILoggerService _loggerService;
        private readonly IProgressService<double> _progressService;

        
        


        private string _remoteUri;
        private string _assemblyName;
        private Action<FileInfo, bool> _updateAction;

        private bool _isInitialized;
        
        #endregion

        public UpdateService(
            INotificationService notificationService,
            IProgressService<double> progressService,
            ILoggerService loggerService)
        {
            _loggerService = loggerService;
            _notificationService = notificationService;
            _progressService = progressService;
        }

        #region properties

        public bool IsUpdateAvailable { get; set; }
        public bool IsUpdateReadyToInstall { get; set; }

        #endregion

        #region methods

        /// <summary>
        /// Initializes the Updatemanager
        /// </summary>
        /// <param name="updateUrl">full url to where the manifest is located</param>
        /// <param name="assemblyName">loaded assembly name to check the version against</param>
        /// <param name="updateAction">action to execute for managed installs</param>
        public void Init(string updateUrl, string assemblyName, Action<FileInfo, bool> updateAction)
        {
            _remoteUri = updateUrl;
            _assemblyName = assemblyName;
            _updateAction = updateAction;

            _isInitialized = true;
        }

        private Uri GetManifestUri() => new($"{_remoteUri.TrimEnd('/')}/{Constants.Manifest}" );

        private static bool IsManaged() => File.Exists(Path.GetFullPath(Constants.ManagedRegistration));

        /// <summary>
        /// Public entry point to check for updates 
        /// </summary>
        /// <returns></returns>
        public async Task CheckForUpdatesAsync()
        {
            if (!_isInitialized)
            {
                return;
            }

            // check versions
            var http = new HttpClient();
            var manifestJson = await http.GetStringAsync(GetManifestUri());
            var manifest = JsonSerializer.Deserialize<Manifest>(manifestJson);
            if (manifest == null)
            {
                return;
            }
            var latestVersion = new Version(manifest.Version);
            var myVersion = CommonFunctions.GetAssemblyVersion(_assemblyName);

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

            async Task HandleUpdate(EIncludedFiles type)
            {
                // check if update already downloaded before
                var physicalPath = new FileInfo(Path.Combine(Path.GetTempPath(), manifest.Get(type).Key));
                if (physicalPath.Exists)
                {
                    using (var mySha256 = SHA256.Create())
                    {
                        var hash = CommonFunctions.HashFile(physicalPath, mySha256);
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
            var latestVersion = new Version(manifest.Version);

            _notificationService.Ask($"Update available. Would you like to update to the latest version {latestVersion}?",
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
                                _progressService.Report(d / 100);
                            });

                        _ = dlCompleteObservable
                            .Select(_ => _.EventArgs)
                            .Subscribe(c =>
                            {
                                OnDownloadCompletedCallback(c, manifest, type);
                            });

                        var uri = new Uri($"{_remoteUri.TrimEnd('/')}/{manifest.Get(type).Key}");
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
                _loggerService.Info("File download cancelled.");
            }

            if (e.Error != null)
            {
                _loggerService.Error(e.Error.ToString());
            }

            // check downloaded file
            var physicalPath = new FileInfo(Path.Combine(Path.GetTempPath(), manifest.Get(type).Key));
            if (physicalPath.Exists)
            {
                using (var mySha256 = SHA256.Create())
                {
                    var hash = CommonFunctions.HashFile(physicalPath, mySha256);
                    if (manifest.Get(type).Value.Equals(hash))
                    {
                        HandleUpdateFromFile(physicalPath);
                    }
                    else
                    {
                        _loggerService.Error("Downloaded file does not match expected file.");
                    }
                }
            }
            else
            {
                _loggerService.Error("File download failed.");
            }
        }

        private void HandleUpdateFromFile(FileInfo path)
        {
            IsUpdateAvailable = false;
            IsUpdateReadyToInstall = true;

            // ask user to restart
            _notificationService.Ask($"Update ready to install - restart?", delegate(bool b)
            {
                if (!b)
                {
                    return true;
                }

                _updateAction(path, IsManaged());

                return true;
            });
        }

        #endregion
    }
}
