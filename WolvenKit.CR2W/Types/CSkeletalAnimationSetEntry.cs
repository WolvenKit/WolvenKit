using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CSkeletalAnimationSetEntry : CVector
    {
        public List<CVariable> entries = new List<CVariable>();

        public CSkeletalAnimationSetEntry(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var count = file.ReadInt32();
            for (var i = 0; i < count; i++)
            {
                var elementsize = file.ReadUInt32();
                //var nameId = file.ReadUInt16();
                var typeId = file.ReadUInt16();
                var typeName = cr2w.names[typeId].str;
                //var varname = cr2w.strings[nameId].str;

                var item = CR2WTypeManager.Get().GetByName(typeName, typeName, cr2w, false);
                if (item == null)
                    item = new CVector(cr2w);


                item.Read(file, elementsize);
                item.Type = typeName;
                item.Name = typeName;
                entries.Add(item);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            file.Write((uint) entries.Count);
            foreach (var item in entries)
            {
                var startpos = file.BaseStream.Position;

                file.Write((uint) 0);
                //file.Write(item.nameId);
                file.Write(item.typeId);

                item.Write(file);

                var endpos = file.BaseStream.Position;
                var newsize = (uint) (endpos - startpos);

                file.Seek((int) startpos, SeekOrigin.Begin);
                file.Write(newsize);
                file.Seek((int) endpos, SeekOrigin.Begin);
            }
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSkeletalAnimationSetEntry(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CSkeletalAnimationSetEntry) base.Copy(context);

            foreach (var item in entries)
            {
                var.entries.Add(item.Copy(context));
            }

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(new EditableList<CVariable>(entries, cr2w) {Name = "entries"});
            return list;
        }
    }
}