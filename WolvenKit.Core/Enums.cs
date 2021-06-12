// ReSharper disable InconsistentNaming

namespace WolvenKit.Common
{
    public enum ERedExtension
    {
        actionanimdb,
        acousticdata,
        aiarch,
        animgraph,
        anims,
        app,
        archetypes,
        areas,
        audio_metadata,
        audiovehcurveset,
        behavior,
        bikecurveset,
        bk2,
        bnk,
        camcurveset,
        cfoliage,
        charcustpreset,
        cminimap,
        community,
        conversations,
        cooked_mlsetup,
        cookedanims,
        cookedapp,
        credits,
        csv,
        cubemap,
        curveset,
        dat,
        devices,
        dtex,
        effect,
        ent,
        env,
        envparam,
        envprobe,
        es,
        facialcustom,
        facialsetup,
        fb2tl,
        fnt,
        folbrush,
        foldest,
        fp,
        gamedef,
        garmentlayerparams,
        genericanimdb,
        geometry_cache,
        gidata,
        gradient,
        hitrepresentation,
        hp,
        ies,
        inkanim,
        inkatlas,
        inkcharcustomization,
        inkfontfamily,
        inkfullscreencomposition,
        inkgamesettings,
        inkhud,
        inklayers,
        inkmenu,
        inkshapecollection,
        inkstyle,
        inktypography,
        inkwidget,
        interaction,
        journal,
        journaldesc,
        json,
        lane_connections,
        lane_polygons,
        lane_spots,
        lights,
        lipmap,
        location,
        locopaths,
        loot,
        mappins,
        mesh,
        mi,
        mlmask,
        mlsetup,
        mltemplate,
        morphtarget,
        mt,
        navmesh,
        null_areas,
        opusinfo,
        opuspak,
        particle,
        phys,
        physicalscene,
        physmatlib,
        poimappins,
        psrep,
        quest,
        questphase,
        regionset,
        remt,
        reslist,
        rig,
        scene,
        scenerid,
        scenesversions,
        smartobject,
        smartobjects,
        sp,
        spatial_representation,
        streamingquerydata,
        streamingsector,
        streamingsector_inplace,
        streamingworld,
        terrainsetup,
        texarray,
        traffic_collisions,
        traffic_persistent,
        voicetags,
        w2mesh,
        w2mi,
        wem,
        workspot,
        xbm,
        xcube
    }


    public enum Logtype
    {
        Normal,
        Error,
        Important,
        Success,
        Warning,
        Wcc
    }

    public enum EArchiveType
    {
        ANY,
        Bundle,
        CollisionCache,
        TextureCache,
        SoundCache,
        Speech,
        Archive,
        Shader,
    }

    /// <summary>
    /// Possible file extensions of cooked redengine files
    /// </summary>
    public enum ECookedFileFormat
    {
        NONE,
        wem,
        mesh,
        xbm,
        csv,
        //json,
        mlmask,
        cubemap,
        envprobe,
        texarray,
        morphtarget,
        fnt
    }

    /// <summary>
    /// Possible file extensions of raw files
    /// </summary>
    public enum ERawFileFormat
    {
        tga,
        dds,
        fbx,
        gltf,
        glb,
        ttf
    }

    /// <summary>
    /// Possible file extensions of raw files
    /// </summary>
    public enum EExportState
    {
        Exportable,
        Importable
    }

    public enum ECustomImageKeys
    {
        OpenDirImageKey, //= "<ODIR>";
        ClosedDirImageKey, //= "<CDIR>";
        ModImageKey, //= "<MOD>";
        DlcImageKey, //= "<DLC>";
        DlcCookedImageKey, //= "<DLCC>";
        DlcUncookedImageKey, //= "<DLCU>";
        ModCookedImageKey, //= "<MODC>";
        ModUncookedImageKey, //= "<MODU>";
        RawImageKey, //= "<RAW>";
        RadishImageKey,
        RawModImageKey,
        RawDlcImageKey
    }

    public enum EFileReadErrorCodes
    {
        NoError,
        NoCr2w,
        UnsupportedVersion,
    }

    public enum EProjectFolders
    {
        Cooked,
        Uncooked,
        Raw
    }




    /// IMPORT FLAGS
    [System.Flags]
    public enum EImportFlags
    {
        Default = 0x0,      // done
        Obligatory = 0x1,
        Template = 0x2,     // done
        Soft = 0x4,         // done
        HashedPath = 0x8,
        Inplace = 0x10,     // done
    };
}
