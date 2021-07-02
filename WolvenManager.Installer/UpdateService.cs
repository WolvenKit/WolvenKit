using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Reactive.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools;

namespace WolvenManager.Installer
{
    public class UpdateService : IUpdateService
    {
        private readonly INotificationService _notificationService;
        private readonly ILoggerService _loggerService;

        private string _remoteUri;
        private string _assemblyName;
        private Action<FileInfo> _updateAction;

        public UpdateService(
            INotificationService notificationService,
            ILoggerService loggerService)
        {
            _loggerService = loggerService;
            
            _notificationService = notificationService;


        }


        #region properties

        public bool IsUpdateAvailable { get; set; }
        public bool IsUpdateReadyToInstall { get; set; }
        public double Progress { get; set; }

        #endregion

        #region methods

        /// <summary>
        /// /releases/latest/download/
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="assemblyName"></param>
        /// <param name="updateAction"></param>
        public void Init(string uri, string assemblyName, Action<FileInfo> updateAction)
        {
            _remoteUri = uri;
            _assemblyName = assemblyName;
            _updateAction = updateAction;
        }

        private Uri GetManifestUri() => new($"{_remoteUri.TrimEnd('/')}/{Constants.Manifest}" );

        private bool IsManagedInstal() => File.Exists(Path.GetFullPath(Constants.ManagedRegistration));

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task CheckForUpdatesAsync()
        {
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
                if (IsManagedInstal())
                {
                    await HandleManagedInstals();
                }
                else
                {
                    await HandlePortableInstals();
                }
            }

            async Task HandleManagedInstals()
            {
                // check if update already downloaded before
                var physicalPath = new FileInfo(Path.Combine(Path.GetTempPath(), manifest.Installer.Key));
                if (physicalPath.Exists)
                {
                    using (var mySha256 = SHA256.Create())
                    {
                        var hash = CommonFunctions.HashFile(physicalPath, mySha256);
                        if (manifest.Installer.Value.Equals(hash))
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
                                await DownloadUpdateAsync(manifest, manifest.Installer.Key);
                            }
                        }
                    }
                }
                else
                {
                    await DownloadUpdateAsync(manifest, manifest.Installer.Key);
                }
            }

#pragma warning disable 1998
            async Task HandlePortableInstals()
#pragma warning restore 1998
            {
                throw new NotImplementedException();
            }
        }

        private async Task DownloadUpdateAsync(Manifest manifest, string filename)
        {
            var latestVersion = new Version(manifest.Version);
            var myVersion = CommonFunctions.GetAssemblyVersion(_assemblyName);

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
                                Progress = d;
                            });

                        _ = dlCompleteObservable
                            .Select(_ => _.EventArgs)
                            .Subscribe(c =>
                            {
                                OnDownloadCompletedCallback(c, manifest, filename);
                            });

                        var uri = new Uri($"{_remoteUri.TrimEnd('/')}/{filename}");
                        var physicalPath = Path.Combine(Path.GetTempPath(), filename);
                        wc.DownloadFileAsync(uri, physicalPath);
                    }
                    return true;
                });

            await Task.CompletedTask;
        }

        private void OnDownloadCompletedCallback(AsyncCompletedEventArgs e, Manifest manifest, string key)
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
            var physicalPath = new FileInfo(Path.Combine(Path.GetTempPath(), manifest.Installer.Key));
            if (physicalPath.Exists)
            {
                using (var mySha256 = SHA256.Create())
                {
                    var hash = CommonFunctions.HashFile(physicalPath, mySha256);
                    if (manifest.Installer.Value.Equals(hash))
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

                if (IsManagedInstal())
                {
                    _updateAction(path);
                }
                else
                {
                    throw new NotImplementedException();
                }

                return true;
            });
        }

        #endregion
    }
}
