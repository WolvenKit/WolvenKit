using System.Collections.Generic;
using System.IO;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CCubeTexture : CResource
    {
        // 20 bytes header
        [REDBuffer] public CUInt32 Texturecachekey { get; set; }

        [REDBuffer] public CUInt16 Residentmip { get; set; }
        [REDBuffer] public CUInt16 Encodedformat { get; set; }

        [REDBuffer] public CUInt16 Edge { get; set; }
        [REDBuffer] public CUInt16 Mipmapscount { get; set; }

        [REDBuffer] public CUInt32 Filesize { get; set; }
        [REDBuffer] public CInt32 Ffffffff { get; set; }

        [REDBuffer(true)] public CBytes Rawfile { get; set; }


        public CCubeTexture(CR2WFile cr2w) : base(cr2w)
        {
            
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            Rawfile = new CBytes(cr2w) { Name = "Image" };
            Rawfile.Read(file, Filesize.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Rawfile.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCubeTexture(cr2w);
        }

        
    }
}