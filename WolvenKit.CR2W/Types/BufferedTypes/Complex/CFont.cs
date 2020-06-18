using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CFont : CResource
    {
        [RED("textures", 2, 0)] public CArray<CHandle<CBitmapTexture>> Textures { get; set; }

        [REDBuffer(true)] public CArray<CUInt16> Unicodemapping { get; set; }
        [REDBuffer(true)] public CInt32 Linedist { get; set; }
        [REDBuffer(true)] public CInt32 Maxglyphheight { get; set; }
        [REDBuffer(true)] public CBool Kerning { get; set; }
        [REDBuffer(true)] public CArray<CArray<CFloat>> Glyphs { get; set; }



        public CFont(CR2WFile cr2w) : base(cr2w)
        {
            Unicodemapping = new CArray<CUInt16>(cr2w);
            Linedist = new CInt32(cr2w);
            Maxglyphheight = new CInt32(cr2w);
            Kerning = new CBool(cr2w);
            Glyphs = new CArray<CArray<CFloat>>(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var cnt = file.ReadVLQInt32();
            for (int i = 0; i < cnt; i++)
            {
                //This is actually a byte-byte pair but no idea why or how anyone would edit this
                var mapping = new CUInt16(cr2w);
                mapping.Read(file, size);
                Unicodemapping.AddVariable(mapping);
            }
            Linedist.Read(file, size);
            Maxglyphheight.Read(file, size);
            Kerning.Read(file, size);

            var num = file.ReadVLQInt32();

            for(int i = 0; i < num; i++)
            {
                var glyph = new CArray<CFloat>(cr2w)
                {
                    Name = "Glyph - " + i
                };
                // UVs
                CFloat uv00 = new CFloat(cr2w) { Name = "UV[0][0]" };
                uv00.Read(file, size);
                glyph.AddVariable(uv00);
                CFloat uv01 = new CFloat(cr2w) { Name = "UV[0][1]" };
                uv01.Read(file, size);
                glyph.AddVariable(uv01);
                CFloat uv10 = new CFloat(cr2w) { Name = "UV[1][0]" };
                uv10.Read(file, size);
                glyph.AddVariable(uv10);
                CFloat uv11 = new CFloat(cr2w) { Name = "UV[1][1]" };
                uv11.Read(file, size);
                glyph.AddVariable(uv11);

                CInt32 textureindex = new CInt32(cr2w) { Name = "Texture index" };
                textureindex.Read(file, size);
                glyph.AddVariable(textureindex);
                CInt32 width = new CInt32(cr2w) { Name = "Width" };
                width.Read(file, size);
                glyph.AddVariable(width);
                CInt32 height = new CInt32(cr2w) { Name = "Height" };
                height.Read(file, size);
                glyph.AddVariable(height);
                CInt32 advance_x = new CInt32(cr2w) { Name = "Advance X" };
                advance_x.Read(file, size);
                glyph.AddVariable(advance_x);
                CInt32 bearing_x = new CInt32(cr2w) { Name = "Bearing X" };
                bearing_x.Read(file, size);
                glyph.AddVariable(bearing_x);
                CInt32 bearing_y = new CInt32(cr2w) { Name = "Bearing Y" };
                bearing_y.Read(file, size);
                glyph.AddVariable(bearing_y);

                Glyphs.AddVariable(glyph);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            file.WriteVLQInt32(Unicodemapping.Count);
            foreach(var mapping in Unicodemapping)
            {
                mapping.Write(file);
            }

            Linedist.Write(file);
            Maxglyphheight.Write(file);
            Kerning.Write(file);

            file.WriteVLQInt32(Glyphs.Count);

            for(int i = 0; i < Glyphs.Count; i++)
            {
               foreach(var subelement in (Glyphs[i]).elements)
               {
                    subelement.Write(file);
               }
            }

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFont(cr2w);
        }
    }
}
