using System;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Options;
using WolvenKit.App.Helpers;
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
        _tdbs = IocHelper.GetService<TweakDBService>();
        _settingsManager = IocHelper.GetService<ISettingsManager>();
        _loggerService = IocHelper.GetService<ILoggerService>();
        _projectManager = IocHelper.GetService<IProjectManager>();
        _archiveManager = IocHelper.GetService<IArchiveManager>();
        _scriptService = IocHelper.GetService<ExtendedScriptService>();
        _parserService = IocHelper.GetService<Red4ParserService>();
        _hashService = IocHelper.GetService<IHashService>();
        _globals = IocHelper.GetService<IOptions<Globals>>();
        _watcherService = IocHelper.GetService<IWatcherService>();
        _appViewModel = IocHelper.GetService<AppViewModel>();

        _filePath = path;

        State = DockState.Document;
        SideInDockedMode = DockSide.Tabbed;
    }

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
