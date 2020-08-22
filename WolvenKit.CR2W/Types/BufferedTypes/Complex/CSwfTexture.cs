using System.Collections.Generic;
using System.IO;
using System;
using WolvenKit.CR2W.Editors;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{

    public partial class CSwfTexture : CBitmapTexture
    {

        //[REDBuffer(true)] public CBytes swfTexture { get; set; }

        public CSwfTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            //swfTexture = new CBytes(cr2w, this, nameof(swfTexture));
        }

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;

            base.Read(file, size);

            //var textureSize = Convert.ToInt32( size - (file.BaseStream.Position - pos) );

            //swfTexture.Read(file, (uint)textureSize);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            //swfTexture.Write(file);
        }

    }
}