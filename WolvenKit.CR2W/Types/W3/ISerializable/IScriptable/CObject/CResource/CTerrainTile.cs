using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types.W3.ISerializable.IScriptable.CObject.CResource.ITexture
{
    class CTerrainTile : CVector
    {
        public CArray groups;


        public CTerrainTile(CR2WFile cr2w) : base(cr2w)
        {
            groups = new CArray(cr2w)
            {
                Name = "Groups"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var cnt = file.ReadInt32();
            for(int i = 0; i < cnt; i++)
            {
                CArray group = new CArray(cr2w) {
                    Name = "Group - " + i
                };

                CInt16 lod1 = new CInt16(cr2w) 
                {
                    Name = "Lod1"
                };
                lod1.val = file.ReadInt16();
                group.AddVariable(lod1);

                CInt16 lod2 = new CInt16(cr2w)
                {
                    Name = "Lod2"
                };
                lod2.val = file.ReadInt16();
                group.AddVariable(lod2);

                CInt16 lod3 = new CInt16(cr2w)
                {
                    Name = "Lod3"
                };
                lod3.val = file.ReadInt16();
                group.AddVariable(lod3);

                CInt32 res = new CInt32(cr2w)
                {
                    Name = "Resolution"
                };
                res.val = file.ReadInt32();
                group.AddVariable(res);

                groups.AddVariable(group);
            }
            var maxres = file.ReadInt32();
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            file.Write(groups.array.Count);
            foreach(var v in groups.array)
            {
                var group = ((CArray)v).array;
                file.Write((group[0] as CInt16).val);
                file.Write((group[1] as CInt16).val);
                file.Write((group[2] as CInt16).val);
                file.Write((group[3] as CInt32).val);
            }
            file.Write(((CInt32)groups.array.Max(x => (((CArray)x).array[3] as CInt32))).val);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CTerrainTile)base.Copy(context);

            var.groups = (CArray)groups.Copy(context);

            return var;
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CTerrainTile(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>() { 
                groups
            }.Concat(base.GetEditableVariables().ToArray()).ToList();
        }
    }
}
