using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    /// <summary>
    /// A generic wrapper class for a single CVariable
    /// Format: [ushort typeID] [uint size] [byte[size] data]
    /// </summary>
    [REDMeta()]
    public class CVariant : CVariable
    {
        public CVariable Variant;

        public CVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            var typepos = file.BaseStream.Position;

            var typeId = file.ReadUInt16();
            var typename = cr2w.names[typeId].Str;

            var varsize = file.ReadUInt32() - 4;


            Variant = CR2WTypeManager.Create(typename, "", cr2w, this);
            Variant.Read(file, varsize);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(Variant.GettypeId());

            byte[] buffer = System.Array.Empty<byte>();
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                Variant.Write(bw);
                buffer = ms.ToArray();
            }
            file.Write(buffer.Length + 4);
            file.Write(buffer);

            //var pos = file.BaseStream.Position;
            //file.Write((uint) 0); // size placeholder

            //Variant.Write(file);
            //var endpos = file.BaseStream.Position;

            //file.Seek((int) pos, SeekOrigin.Begin);
            //var actualsize = (uint) (endpos - pos);
            //file.Write(actualsize); // Write size
            //file.Seek((int) endpos, SeekOrigin.Begin);
        }

        public override CVariable SetValue(object val)
        {
            if (val is CVariable)
            {
                Variant = (CVariable) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CVariant(cr2w, parent, name);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CVariant) base.Copy(context);
            var.Variant = var.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>
            {
                Variant
            };
            return list;
        }

        public override Control GetEditor()
        {
            if (Variant != null)
                return Variant.GetEditor();
            return null;
        }

        public override string ToString()
        {
            if (Variant != null)
                return Variant.ToString();
            return "";
        }

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is CVariable;
        }

        public override void AddVariable(CVariable var)
        {
            this.Variant = var;
        }
    }
}