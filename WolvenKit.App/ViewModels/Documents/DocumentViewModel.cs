using System;
using System.IO;
using System.Reactive;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Options;
using ReactiveUI;
using Splat;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.ViewModels.Documents;

public abstract partial class DocumentViewModel : PaneViewModel, IDocumentViewModel
{
    protected readonly TweakDBService _tdbs;
    protected readonly ISettingsManager _settingsManager;
    protected readonly ILoggerService _loggerService;
    protected readonly IProjectManager _projectManager;
    protected readonly IArchiveManager _archiveManager;
    protected readonly ExtendedScriptService _scriptService;
    protected readonly Red4ParserService _parserService;
    protected readonly IHashService _hashService;
    protected readonly IOptions<Globals> _globals;
    protected readonly IWatcherService _watcherService;
    protected readonly AppViewModel _appViewModel;

    protected bool _isInitialized;


    public DocumentViewModel(string path) : base(Path.GetFileName(path), path)
    {
        _tdbs = Locator.Current.GetService<TweakDBService>().NotNull();
        _settingsManager = Locator.Current.GetService<ISettingsManager>().NotNull();
        _loggerService = Locator.Current.GetService<ILoggerService>().NotNull();
        _projectManager = Locator.Current.GetService<IProjectManager>().NotNull();
        _archiveManager = Locator.Current.GetService<IArchiveManager>().NotNull();
        _scriptService = Locator.Current.GetService<ExtendedScriptService>().NotNull();
        _parserService = Locator.Current.GetService<Red4ParserService>().NotNull();
        _hashService = Locator.Current.GetService<IHashService>().NotNull();
        _globals = Locator.Current.GetService<IOptions<Globals>>().NotNull();
        _watcherService = Locator.Current.GetService<IWatcherService>().NotNull();
        _appViewModel = Locator.Current.GetService<AppViewModel>().NotNull();

        _filePath = path;

        State = DockState.Document;
        SideInDockedMode = DockSide.Tabbed;

        Close = ReactiveCommand.Create(() => { });
    }

    #region commands


    public ReactiveCommand<Unit, Unit> Close { get; set; }

    #endregion commands

    #region Properties

    [ObservableProperty] private string _filePath;

    private bool _isDirty;

    public bool IsDirty
    {
        get => _isDirty;
        protected set => SetProperty(ref _isDirty, value);
    }

    #endregion Properties

    #region methods

    public bool IsInitialized() => _isInitialized;

    public void SetIsDirty(bool b)
    {
        IsDirty = b;
        Header = GetHeader();
    }

    private string GetHeader() => Path.GetFileName(ContentId) + (IsDirty ? "*" : "");


    [RelayCommand]
    public abstract Task Save(object parameter);

    [RelayCommand]
    public abstract void SaveAs(object parameter);


    #endregion methods


}
