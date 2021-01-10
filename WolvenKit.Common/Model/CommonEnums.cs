using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// REDENgine textureformat
    /// </summary>
    //public enum ETextureFormat
    //{
    //    // x = 1 or param1
    //    TEXFMT_A8 = 0x0,  // ret 0
    //    TEXFMT_A8_Scaleform = 0x1, //ret 0
    //    TEXFMT_L8 = 0x2,    // ret 0
    //    TEXFMT_R8G8B8X8 = 0x3,  //ret x4
    //    TEXFMT_R8G8B8A8 = 0x4,  //ret x4
    //    TEXFMT_A8L8 = 0x5,  //ret x2
    //    TEXFMT_Uint_16_norm = 0x6,  //ret x2
    //    TEXFMT_Uint_16 = 0x7,  //ret x2
    //    TEXFMT_Uint_32 = 0x8,
    //    TEXFMT_R32G32_Uint = 0x9,  //ret x8
    //    TEXFMT_R16G16_Uint = 0xA,    //ret << 4
    //    TEXFMT_Float_R10G10B10A2 = 0xB,  //ret x4
    //    TEXFMT_Float_R16G16B16A16 = 0xC,  //ret x8
    //    TEXFMT_Float_R11G11B10 = 0xD,  //ret x4
    //    TEXFMT_Float_R16G16 = 0xE,  //ret x4
    //    TEXFMT_Float_R32G32 = 0xF,  //ret x8
    //    TEXFMT_Float_R32G32B32A32 = 0x10,  //ret x4
    //    TEXFMT_Float_R32 = 0x11,  //ret x4
    //    TEXFMT_Float_R16 = 0x12,  //ret x2
    //    TEXFMT_D24S8 = 0x13,  //ret x4
    //    TEXFMT_D24FS8 = 0x14,
    //    TEXFMT_D32F = 0x15,
    //    TEXFMT_D16U = 0x16,
    //    TEXFMT_BC1 = 0x17,  //ret (7 < x*2) ? x*2 : 8
    //    TEXFMT_BC2 = 0x18,  //ret (0xf < x*4) ? x*4 : 0x10
    //    TEXFMT_BC3 = 0x19,  //ret (0xf < x*4) ? x*4 : 0x10
    //    TEXFMT_BC4 = 0x1A,  //ret (7 < x*2) ? x2 : 8
    //    TEXFMT_BC5 = 0x1B,  //ret (0xf < x*4) ? x*4 : 0x10
    //    TEXFMT_BC6H = 0x1C,  //ret (0xf < x*4) ? x*4 : 0x10
    //    TEXFMT_BC7 = 0x1D,  //ret (0xf < x*4) ? x*4 : 0x10
    //    TEXFMT_R8_Uint = 0x1E,  // ret 0
    //    TEXFMT_NULL = 0x1F,
    //    //TEXFMT_Max = 0x20,
    //};

    


    public enum EUncookExtension
    {
        tga,
        bmp,
        jpg,
        jpeg,
        png,
        dds,
        //HDR,
        //TIF,
        //TIFF,
        //WDP,
        //HDP,
        //JXR
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

    public enum EProjectFolders
    {
        Cooked,
        Uncooked,
        Raw
    }

    public enum EFileReadErrorCodes
    {
        NoError,
        NoCr2w,
        UnsupportedVersion,
    }
}
