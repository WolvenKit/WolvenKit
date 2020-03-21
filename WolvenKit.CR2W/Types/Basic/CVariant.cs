using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CVariant : CVariable
    {
        public CVariable var;

        public CVariant(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            var typepos = file.BaseStream.Position;
            var typeId = file.ReadUInt16();

            var varsize = file.ReadUInt32() - 4;
            var typename = cr2w.names[typeId].Str;
            var varname = cr2w.names[nameId].Str;

            var = CR2WTypeManager.Get().GetByName(typename, varname, cr2w);
            var.Read(file, varsize);

            var.nameId = nameId;
            var.typeId = typeId;
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(var.typeId);

            var pos = file.BaseStream.Position;
            file.Write((uint) 0); // size placeholder


            var.Write(file);
            var endpos = file.BaseStream.Position;

            file.Seek((int) pos, SeekOrigin.Begin);
            var actualsize = (uint) (endpos - pos);
            file.Write(actualsize); // Write size
            file.Seek((int) endpos, SeekOrigin.Begin);
        }

        public override CVariable SetValue(object val)
        {
            if (val is CVariable)
            {
                var = (CVariable) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CVariant(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CVariant) base.Copy(context);
            var.var = var.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>();
            list.Add(var);
            return list;
        }

        public override Control GetEditor()
        {
            if (var != null)
                return var.GetEditor();
            return null;
        }

        public override string ToString()
        {
            if (var != null)
                return var.ToString();
            return "";
        }

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is CVariable;
        }

        public override void AddVariable(CVariable var)
        {
            this.var = var;
        }
    }
}