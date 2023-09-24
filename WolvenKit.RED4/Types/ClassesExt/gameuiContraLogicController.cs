namespace WolvenKit.RED4.Types;

public partial class gameuiContraLogicController : inkWidgetLogicController
{
    [RED("playerLibraryName")]
    public CName PlayerLibraryName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("gameplayRoot")]
    public inkCompoundWidgetReference GameplayRoot
    {
        get => GetPropertyValue<inkCompoundWidgetReference>();
        set => SetPropertyValue<inkCompoundWidgetReference>(value);
    }

    [RED("baseSpeed")]
    public CFloat BaseSpeed
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("layers")]
    public CArray<inkWidgetReference> Layers
    {
        get => GetPropertyValue<CArray<inkWidgetReference>>();
        set => SetPropertyValue<CArray<inkWidgetReference>>(value);
    }

    [RED("playerSpawnHeight")]
    public CFloat PlayerSpawnHeight
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("mainMenuScreenLibraryName")]
    public CName MainMenuScreenLibraryName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("scoreboardScreenLibraryName")]
    public CName ScoreboardScreenLibraryName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("uiLayerName")]
    public CName UiLayerName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("gameLayerName")]
    public CName GameLayerName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("platformLayerName")]
    public CName PlatformLayerName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("backgroundLayerName")]
    public CName BackgroundLayerName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("tileLibraryName")]
    public CName TileLibraryName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("platformLibraryName")]
    public CName PlatformLibraryName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("platformTexturePartName")]
    public CName PlatformTexturePartName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("RoadTexturePartName")]
    public CName RoadTexturePartName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("middlePlatformMinDistance")]
    public CFloat MiddlePlatformMinDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("middlePlatformMaxDistance")]
    public CFloat MiddlePlatformMaxDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("topPlatformPosition")]
    public CFloat TopPlatformPosition
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("bottomPlatformPosition")]
    public CFloat BottomPlatformPosition
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("fenceLibraryName")]
    public CName FenceLibraryName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("fenceSpawnDistance")]
    public CFloat FenceSpawnDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    public gameuiContraLogicController()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}