using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model
{
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


    public enum EBundleType
    {
        ANY,
        Bundle,
        CollisionCache,
        TextureCache,
        SoundCache,
        Speech,
        //Uncooked
    }
}
