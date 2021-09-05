// ReSharper disable InconsistentNaming

namespace WolvenKit.Common
{
    public enum EWolvenKitFile
    {
        Cr2w,
        Redscript,
        Tweak
    }

    public enum ERedScriptExtension
    {
        SWIFT
    }

    public enum ETweakExtension
    {
        TWEAK
    }

    public enum EUpdateChannel
    {
        Stable,
        Nightly
    }

    public enum ESerializeFormat
    {
        json,
        xml
    }

    public enum EVanillaArchives
    {
        audio_1_general,
        audio_2_soundbanks,
        basegame_1_engine,
        basegame_2_mainmenu,
        basegame_3_nightcity,
        basegame_3_nightcity_gi,
        basegame_3_nightcity_terrain,
        basegame_4_animation,
        basegame_4_appearance,
        basegame_4_gamedata,
        basegame_5_video,

        lang_ar_text,
        lang_cs_text,
        lang_de_text,
        lang_en_text,
        lang_en_voice,
        //lang_es-es_text,
        //lang_es-mx_text,
        lang_fr_text,
        lang_hu_text,
        lang_it_text,
        lang_ja_text,
        lang_ko_text,
        lang_pl_text,
        lang_pt_text,
        lang_ru_text,
        lang_th_text,
        lang_tr_text,
        //lang_zh-cn_text,
        //lang_zh-tw_text
    }

    public enum ERedExtension
    {
        acousticdata,
        actionanimdb,
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
        curveresset,
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
        game,
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
        matlib,
        mesh,
        mi,
        mlmask,
        mlsetup,
        mltemplate,
        morphtarget,
        mt,
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
        reps,
        reslist,
        rig,
        scene,
        scenerid,
        scenesversions,
        smartobject,
        smartobjects,
        sp,
        spatial_representation,
        streamingsector,
        streamingsector_inplace,
        streamingworld,
        terrainsetup,
        texarray,
        traffic_collisions,
        traffic_persistent,
        vehcommoncurveset,
        vehcurveset,
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
        wem,
        mesh,
        xbm,
        csv,
        //app,
        //ent,
        //json,
        mlmask,

        cubemap,
        envprobe,
        texarray,
        morphtarget,
        fnt,
        opusinfo,
        anims
    }

    /// <summary>
    /// Possible file extensions of raw files
    /// </summary>
    public enum ERawFileFormat
    {
        bmp = 0,
        jpg = 1,
        png = 2,
        tga = 3,
        tiff = 4,
        dds = 5,
        fbx,
        gltf,
        glb,
        ttf,
        wav,
        masklist
    }

    public enum EConvertableOutput
    {
        fbx,
        x,
        stp,
        obj,
        stl,
        ply,
        assbin,
        assxml,
        x3d
    }

    public enum EConvertableFileFormat
    {
        gltf,
        glb,
        x,
        stp,
        obj,
        stl,
        ply,
        assbin,
        assxml,
        x3d,
        fbx,

    }

    /// <summary>
    /// Possible file extensions of cooked redengine files
    /// </summary>
    public enum ECookedTextureFormat
    {
        xbm,
        mlmask,
        cubemap,
        envprobe,
        texarray,
    }


    /// <summary>
    /// Possible extensions to uncook textures
    /// </summary>
    public enum EUncookExtension
    {
        bmp = 0,
        jpg = 1,
        png = 2,
        tga = 3,
        tiff = 4,
        dds = 5
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
