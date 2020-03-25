using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types.W3.ISerializable.IScriptable.CObject.CResource.ITexture
{
    class CFont : CVector
    {
        public CArray unicodemapping;
        
        public CInt32 linedist;
        public CInt32 maxglyphheight;
        public CBool kerning;

        public CArray glyphs;



        public CFont(CR2WFile cr2w) : base(cr2w)
        {
            unicodemapping = new CArray(cr2w)
            {
                Name = "Unicode mappings"
            };

            linedist = new CInt32(cr2w)
            {
                Name = "Line distance"
            };

            maxglyphheight = new CInt32(cr2w)
            {
                Name = "Max glyph height"
            };

            kerning = new CBool(cr2w)
            {
                Name = "Kerning"
            };

            glyphs = new CArray(cr2w)
            {
                Name = "Glyphs"
            };
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
                unicodemapping.AddVariable(mapping);
            }
            linedist.Read(file, size);
            maxglyphheight.Read(file, size);
            kerning.Read(file, size);

            var num = file.ReadVLQInt32();

            for(int i = 0; i < num; i++)
            {
                CArray glyph = new CArray(cr2w)
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

                glyphs.AddVariable(glyph);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            file.WriteVLQInt32(unicodemapping.array.Count);
            foreach(var mapping in unicodemapping.array)
            {
                mapping.Write(file);
            }

            linedist.Write(file);
            maxglyphheight.Write(file);
            kerning.Write(file);

            file.WriteVLQInt32(glyphs.array.Count);

            for(int i = 0; i < glyphs.array.Count; i++)
            {
               foreach(var subelement in ((CArray)glyphs.array[i]).array)
               {
                    subelement.Write(file);
               }
            }

        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFont)base.Copy(context);

            var.unicodemapping = (CArray)unicodemapping.Copy(context);

            return var;
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFont(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>() {
                unicodemapping,
                glyphs
            }.Concat(base.GetEditableVariables().ToArray()).ToList();
        }
    }
}
