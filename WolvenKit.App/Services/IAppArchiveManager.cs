using System;
using System.Collections.Generic;
using DynamicData;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.App.Services;

public interface IAppArchiveManager : IArchiveManager
{
    #region Properties

    bool IsModBrowserActive { get; set; }

    RedFileSystemModel? RootNode { get; set; }

    public List<RedFileSystemModel> ModRoots { get; }

    #endregion

    public IObservable<IChangeSet<RedFileSystemModel>> ConnectGameRoot();
    public IObservable<IChangeSet<RedFileSystemModel>> ConnectModRoot();
}