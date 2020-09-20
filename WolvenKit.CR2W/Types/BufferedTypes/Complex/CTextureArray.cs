using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    public partial class CTextureArray : CResource
    {


        // 24 bytes header
        [Ordinal(1000)] [REDBuffer] public CUInt32 texturecachekey { get; set; }

        [Ordinal(1001)] [REDBuffer] public CUInt16 encodedformat { get; set; }
        [Ordinal(1002)] [REDBuffer] public CUInt16 width { get; set; }

        [Ordinal(1003)] [REDBuffer] public CUInt16 height { get; set; }
        [Ordinal(1004)] [REDBuffer] public CUInt16 slices { get; set; }

        [Ordinal(1005)] [REDBuffer] public CUInt16 mipmapscount { get; set; }
        [Ordinal(1006)] [REDBuffer] public CUInt16 residentmip { get; set; }

        [Ordinal(1007)] [REDBuffer] public CUInt32 filesize { get; set; }
        [Ordinal(1008)] [REDBuffer] public CInt32 ffffffff { get; set; }

        [Ordinal(1009)] [REDBuffer(true)] public CBytes rawfile { get; set; }


        public CTextureArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

            rawfile = new CBytes(cr2w, this, nameof(rawfile)) { IsSerialized = true };

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            rawfile.Read(file, filesize.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);


            rawfile.Write(file);
        }

    }
}