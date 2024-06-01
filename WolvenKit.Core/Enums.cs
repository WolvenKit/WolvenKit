// ReSharper disable InconsistentNaming

namespace WolvenKit.Common
{
    public enum EInterpolationType
    {
        EIT_Constant,
        EIT_Linear,
        EIT_BezierQuadratic,
        EIT_BezierCubic,
        EIT_Hermite
    }

    public enum ESegmentsLinkType
    {
        ESLT_Normal,
        ESLT_Smooth,
        ESLT_SmoothSymmetric
    };

    public enum EWolvenKitFile
    {
        Cr2w,
        TweakXl,
        ArchiveXl,
        WScript,
        RedScript,
        CETLua
    }

    public enum ERedScriptExtension
    {
        swift,
        reds,
        redscript
    }

    public enum ETweakExtension
    {
        yaml,
        yml
    }

    public enum EWScriptExtension
    {
        wscript
    }

    public enum EUpdateChannel
    {
        Stable,
        Nightly
    }

    public enum ETextConvertFormat
    {
        json,
        //xml
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
        //lang_zh-tw_text,
        memoryresident_1_general
    }

    public enum Logtype
    {
        Normal,
        Error,
        Important,
        Success,
        Warning,
        Debug
    }

    public enum EArchiveSource
    {
        Unknown,
        Base,
        EP1,
        Mod,
        Project
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

    // Target scope for archive manager
    public enum ArchiveManagerScope
    {
        Basegame,
        Mods,
        Everywhere
    }

    /// <summary>
    /// Possible file extensions of cooked redengine files
    /// </summary>
    public enum ECookedFileFormat
    {
        wem,
        mesh,
        w2mesh,
        xbm,
        csv,
        //app,
        //ent,
        //json,
        mlmask,
        cubemap,
        xcube,
        envprobe,
        texarray,
        morphtarget,
        fnt,
        opusinfo,
        anims,
        //ent,
        inkatlas,
        physicalscene
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
        masklist,
        csv,
        re,
        cube
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
        //gltf,
        //glb,
        //x,
        //stp,
        //obj,
        //stl,
        //ply,
        //assbin,
        //assxml,
        //x3d,
        //fbx,

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
        dds,
        tga,
        bmp,
        jpg,
        png,
        tiff,
        cube
    }

    /// <summary>
    /// Possible extensions to uncook textures
    /// </summary>
    public enum EMlmaskUncookExtension
    {
        dds,
        png
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

    public enum EBool : byte
    {
        False,
        True,
        Automatic
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

    public enum EGameLanguage
    {
        ar_ar,
        cz_cz,
        de_de,
        en_us,
        es_es,
        es_mx,
        fr_fr,
        hu_hu,
        it_it,
        jp_jp,
        kr_kr,
        pl_pl,
        pt_br,
        ru_ru,
        th_th,
        tr_tr,
        zh_cn,
        zh_tw,
        ua_ua
    }
}
