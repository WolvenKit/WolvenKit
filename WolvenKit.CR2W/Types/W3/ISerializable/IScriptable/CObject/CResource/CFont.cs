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
        CVariable glyphs;


        public CFont(CR2WFile cr2w) : base(cr2w)
        {
            unicodemapping = new CArray(cr2w)
            {
                Name = "Unicode mappings"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            var cnt = file.ReadVLQInt32();
            for (int i = 0; i < cnt; i++)
            {
                var mapping = new CUInt16(cr2w);
                mapping.Read(file, size);
                unicodemapping.AddVariable(mapping);
            }
            int linedist = file.ReadInt32();
            int maxglyphheight = file.ReadInt32();
            bool kerning = file.ReadBoolean();

            //TODO: Figure this out

            var unk1 = file.ReadInt32();
            var unk2 = file.ReadInt32();
            var unk3 = file.ReadInt32();
            var unk4 = file.ReadInt32();
            var unk5 = file.ReadInt32();
            var unk6 = file.ReadInt32();

            glyphs = cr2w.ReadVariable(file);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            file.WriteVLQInt32(unicodemapping.array.Count);
            foreach(var mapping in unicodemapping.array)
            {
                mapping.Write(file);
            }
            throw new NotImplementedException("Figure out writing!");

            //glyphs.Write(file);
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
                unicodemapping
            }.Concat(base.GetEditableVariables().ToArray()).ToList();
        }
    }
}
