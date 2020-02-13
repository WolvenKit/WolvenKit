using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Wcc
{
    public enum EImportable
    {
        bmp,
        png,
        jpg,
        tga,
        dds,
        apb,
        fbx,
        nxs,
        re
    };

    public enum WFR
    {
        WFR_Error = -1,
        WFR_NotRun = 0,
        WFR_Finished = 1
    }

    /// <summary>
    /// wcc_lite command enums
    /// </summary>
    #region enums
    public enum textureGroupNames
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
        WorldSpecular
    }

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

    public enum platform //null?
    {
        None,
        resave,
        pc,
        ps4,
        xb1
    };

    public enum compression
    {
        None,
        LZ4,
        LZ4HC,
        ZLIB
    };

    public enum imageformat
    {
        None,
        bmp,
        png,
        jpg,
        tga
    };

    /*public enum fbxversion
    {
        fbx2016 = 2016,
        fbx2013 = 2013,
        fbx2011 = 2011,
        fbx2010 = 2010,
        fbx2009 = 2009
    };*/

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

    public enum cachebuilder
    {
        physics,
        shaders,
        textures
    }
    #endregion

}
