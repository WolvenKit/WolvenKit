using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    public partial class CTextureArray : CResource
    {


        // 24 bytes header
        [REDBuffer] public CUInt32 texturecachekey { get; set; }

        [REDBuffer] public CUInt16 encodedformat { get; set; }
        [REDBuffer] public CUInt16 width { get; set; }

        [REDBuffer] public CUInt16 height { get; set; }
        [REDBuffer] public CUInt16 slices { get; set; }

        [REDBuffer] public CUInt16 mipmapscount { get; set; }
        [REDBuffer] public CUInt16 residentmip { get; set; }

        [REDBuffer] public CUInt32 filesize { get; set; }
        [REDBuffer] public CInt32 ffffffff { get; set; }

        [REDBuffer(true)] public CBytes rawfile { get; set; }


        public CTextureArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

            rawfile = new CBytes(cr2w, this, nameof(rawfile));
            
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