using System;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.Common.Wcc
{
    public enum EApbImports
    {
        redcloth,
        redapex
    }

    public enum EExportable
    {
        w2mesh,
        reddest,
        redcloth,
        redapex,
        xbm
    };

    public enum EImportable
    {
        bmp,
        png,
        jpg,
        tga,
        //dds,

        apb,
        fbx,
        nxs,
        //re
    };

    public enum EMeshImports
    {
        w2mesh,
    }

    public enum ENxsImports
    {
        w2mesh,
        reddest
    }

    public enum ETextureImports
    {
        xbm,
        w2cube,
    }

    public enum EWccStatus
    {
        Error = -1,
        NotRun = 0,
        Finished = 1
    }

    public static class REDTypes
    {
        #region Methods

        public static EImportable ExportExtensionToRawExtension(EExportable ext)
        {
            switch (ext)
            {
                case EExportable.w2mesh:
                    return EImportable.fbx;

                case EExportable.reddest:
                    return EImportable.nxs;

                case EExportable.redcloth:
                case EExportable.redapex:
                    return EImportable.apb;

                case EExportable.xbm:
                    return EImportable.tga;

                default:
                    throw new NotImplementedException();
            }
        }

        public static Enum RawExtensionToEnum(string ext)
        {
            ext = ext.ToLower();
            switch (ext)
            {
                case ".apb":
                    return new EApbImports();

                case ".nxs":
                    return new ENxsImports();

                case ".png":
                case ".bmp":
                case ".jpg":
                case ".tga":
                case ".dds":
                    return new ETextureImports();

                case ".re":
                case ".fbx":
                    return new EMeshImports();

                default:
                    throw new NotImplementedException();
            }
        }

        public static List<string> RawExtensionToRedImport(string ext)
        {
            switch (ext)
            {
                case "apb":
                    return Enum.GetNames(typeof(EApbImports)).Select(_ => $".{_}").ToList();

                case "nxs":
                    return Enum.GetNames(typeof(ENxsImports)).Select(_ => $".{_}").ToList();

                case ".re":
                case ".fbx":
                    return Enum.GetNames(typeof(EMeshImports)).Select(_ => $".{_}").ToList();

                case ".jpg":
                case ".pga":
                case ".tga":
                case ".bmp":
                case "dds":
                    return Enum.GetNames(typeof(ETextureImports)).Select(_ => $".{_}").ToList();

                default:
                    return new List<string>();
            }
        }

        #endregion Methods

        //public static string RawExtensionToCacheType(string ext)
        //{
        //    ext = ext.ToLower();
        //    switch (ext)
        //    {
        //        case ".apb":
        //        case ".nxs":
        //            return EBundleType.CollisionCache.ToString();
        //        case ".png":
        //        case ".bmp":
        //        case ".jpg":
        //        case ".tga":
        //        case ".dds":
        //            return EBundleType.TextureCache.ToString();
        //        case ".re":
        //        case ".fbx":
        //            return EBundleType.Archive.ToString();
        //        default: return "";
        //    }
        //}
        //public static string REDExtensionToCacheType(string ext)
        //{
        //    ext = ext.ToLower();
        //    switch (ext)
        //    {
        //        case ".redcloth":
        //        case ".redapex":
        //            return EBundleType.CollisionCache.ToString();
        //        case ".xbm":
        //        case ".w2cube":
        //            return EBundleType.TextureCache.ToString();
        //        case ".w2mesh":
        //            return EBundleType.CollisionCache.ToString();
        //        default:
        //            return EBundleType.CollisionCache.ToString();
        //    }
        //}
    }

    /// <summary>
    /// wcc_lite command enums
    /// </summary>

    #region enums

    public enum analyzers
    {
        world,
        r4res,
        r4items,
        r4game,
        r4common,
        r4gui,
        r4startup,
        r4dlc
    };

    public enum cachebuilder
    {
        physics,
        shaders,
        textures
    }

    public enum compression
    {
        None,
        LZ4,
        LZ4HC,
        ZLIB
    };

    public enum ETextureGroup
    {
        None,
        BillboardAtlas,
        CharacterDiffuse,
        CharacterDiffuseWithAlpha,
        CharacterEmissive,
        CharacterNormal,
        CharacterNormalHQ,
        CharacterNormalmapGloss,
        Default,
        DetailNormalMap,
        DiffuseNoMips,
        Flares,
        FoliageDiffuse,
        Font,
        GUIWithAlpha,
        GUIWithoutAlpha,
        HeadDiffuse,
        HeadDiffuseWithAlpha,
        HeadEmissive,
        HeadNormal,
        HeadNormalHQ,
        MimicDecalsNormal,
        NormalmapGloss,
        NormalsNoMips,
        Particles,
        ParticlesWithoutAlpha,
        PostFxMap,
        QualityColor,
        QualityOneChannel,
        QualityTwoChannels,
        SpecialQuestDiffuse,
        SpecialQuestNormal,
        SystemNoMips,
        TerrainDiffuse,
        TerrainNormal,
        WorldDiffuse,
        WorldDiffuseWithAlpha,
        WorldEmissive,
        WorldNormal,
        WorldNormalHQ,
        WorldSpecular,
        SpeedTreeDiffuseWithAlpha, // not found in ghidra
        SpeedTreeSpecularWithAlpha
    }

    public enum imageformat
    {
        None,
        bmp,
        png,
        jpg,
        tga
    };

    public enum language
    {
        None,
        ar,
        br,
        cz,
        de,
        en,
        es,
        esMX,
        fr,
        hu,
        it,
        jp,
        kr,
        pl,
        ru,
        tr,
        zh
    }

    public enum platform //null?
    {
        None,
        resave,
        pc,
        ps4,
        xb1
    };

    /*public enum fbxversion
    {
        fbx2016 = 2016,
        fbx2013 = 2013,
        fbx2011 = 2011,
        fbx2010 = 2010,
        fbx2009 = 2009
    };*/

    #endregion enums
}
