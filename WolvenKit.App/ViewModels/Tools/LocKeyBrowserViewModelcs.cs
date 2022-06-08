using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using ReactiveUI;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Functionality.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Tools
{
    public class LocKeyBrowserViewModel : ToolViewModel
    {
        #region fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "LocKeyBrowser_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "LocKey Browser";

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly IWatcherService _watcherService;
        private readonly IModTools _modTools;
        private readonly IProgressService<double> _progressService;
        private readonly IGameControllerFactory _gameController;
        private readonly LocKeyService _locKey;
        private readonly IArchiveManager _archive;

        private EditorProject ActiveMod => _projectManager.ActiveProject;

        public string Extension { get; set; } = "json";

        #endregion fields

        #region constructors

        public LocKeyBrowserViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IWatcherService watcherService,
            IProgressService<double> progressService,
            IModTools modTools,
            IGameControllerFactory gameController,
            IArchiveManager archive
        ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _watcherService = watcherService;
            _modTools = modTools;
            _progressService = progressService;
            _gameController = gameController;
            _archive = archive;
            _locKey = Locator.Current.GetService<LocKeyService>();

            //State = DockState.Document;


            if (_archive.IsManagerLoaded)
            {
                SetupLocKeys();
            }
            else
            {
                _ = _archive.WhenAnyValue(x => x.IsManagerLoaded).Subscribe(x =>
                {
                    if (x)
                    {
                        SetupLocKeys();
                    }
                });
            }
        }

        #endregion constructors

        public void SetupLocKeys()
        {
            LocKeys = CollectionViewSource.GetDefaultView(_locKey.GetEntries());
            LocKeys.SortDescriptions.Add(new SortDescription("SecondaryKey", ListSortDirection.Ascending));
            this.RaisePropertyChanged("LocKeys");
        }

        public ICollectionView LocKeys { get; set; }

        private string _searchText = "";
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                LocKeys.Filter = _searchText != ""
                    ? ((obj) =>
                    {
                        if (obj is localizationPersistenceOnScreenEntry entry)
                        {
                            if (entry.FemaleVariant.ToString() != null)
                            {
                                return entry.FemaleVariant.ToString().Contains(_searchText);
                            }
                        }
                        return false;
                    })
                    : null;
                this.RaisePropertyChanged("SearchText");
            }
        }

        private localizationPersistenceOnScreenEntry _selectedLocKey;
        public localizationPersistenceOnScreenEntry SelectedLocKey
        {
            get => _selectedLocKey;
            set
            {
                _selectedLocKey = value;
                this.RaisePropertyChanged("SelectedLocKey");
                if (_selectedLocKey != null)
                {
                    SelectedChunk.Clear();
                    SelectedChunk.Add(new ChunkViewModel(_selectedLocKey, null));
                }
                else
                {
                    SelectedChunk.Clear();
                }
                this.RaisePropertyChanged("SelectedChunk");
            }
        }

        public ObservableCollection<ChunkViewModel> SelectedChunk { get; set; } = new();
    }
}
