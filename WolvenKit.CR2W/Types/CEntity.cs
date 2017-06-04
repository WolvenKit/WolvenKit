using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CEntity : CVector
    {
        public CArray components;
        public CUInt32 unk1;
        public CUInt32 unk2;

        public CEntity(CR2WFile cr2w) :
            base(cr2w)
        {
            unk1 = new CUInt32(cr2w);
            unk1.Name = "unk1";
            unk2 = new CUInt32(cr2w);
            unk2.Name = "unk2";

            components = new CArray("[]handle:Component", "handle:Component", true, cr2w);
            components.Name = "components";
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            unk1.Read(file, 0);
            unk2.Read(file, 0);

            var elementcount = file.ReadBit6();

            for (var i = 0; i < elementcount; i++)
            {
                var handle = new CHandle(cr2w);
                handle.Read(file, 0);
                components.AddVariable(handle);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            unk1.Write(file);
            unk2.Write(file);
            file.WriteBit6(components.array.Count);
            for (var i = 0; i < components.array.Count; i++)
            {
                components.array[i].Write(file);
            }
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CEntity(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CEntity) base.Copy(context);

            var.unk1 = (CUInt32) unk1.Copy(context);
            var.unk2 = (CUInt32) unk2.Copy(context);
            var.components = (CArray) components.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);

            list.Add(unk1);
            list.Add(unk2);
            list.Add(components);

            return list;
        }
    }
}