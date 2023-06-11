namespace WolvenKit.App;

/// <summary>
/// Enumeration of serialized Managers
/// </summary>
public enum EManagerType
{
    BundleManager = 0,
    CollisionManager = 1,
    SoundManager = 2,
    W3StringManager = 3,
    TextureManager = 4,
    ArchiveManager = 5,
    Max = 6
}

public enum EProjectType
{
    cpmodproj,
    w3modproj
}

public enum EAppStatus
{
    None,
    Loaded,
    Busy,
    Ready
}

public enum EDockedViews
{
    LogViewModel,
    ProjectExplorerViewModel,
    PropertiesViewModel,
    AssetBrowserViewModel,
    TweakBrowserViewModel,
    LocKeyBrowserViewModel,
    TextureImportViewModel,
    TextureExportViewModel
}

public enum ScriptSource
{
    System,
    User
}