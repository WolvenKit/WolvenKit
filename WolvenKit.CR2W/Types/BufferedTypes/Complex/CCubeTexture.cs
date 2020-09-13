using System.Collections.Generic;
using System.IO;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    public partial class CCubeTexture : CResource
    {
        // 20 bytes header
        [Ordinal(1000)] [REDBuffer] public CUInt32 Texturecachekey { get; set; }

        [Ordinal(1001)] [REDBuffer] public CUInt16 Residentmip { get; set; }
        [Ordinal(1002)] [REDBuffer] public CUInt16 Encodedformat { get; set; }

        [Ordinal(1003)] [REDBuffer] public CUInt16 Edge { get; set; }
        [Ordinal(1004)] [REDBuffer] public CUInt16 Mipmapscount { get; set; }

        [Ordinal(1005)] [REDBuffer] public CUInt32 Filesize { get; set; }
        [Ordinal(1006)] [REDBuffer] public CInt32 Ffffffff { get; set; }

        [Ordinal(1007)] [REDBuffer(true)] public CBytes Rawfile { get; set; }


        public CCubeTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Rawfile = new CBytes(cr2w, this, "Image") {IsSerialized = true};

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            
            Rawfile.Read(file, Filesize.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Rawfile.Write(file);
        }
    }
}