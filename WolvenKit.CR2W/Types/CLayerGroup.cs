
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class CLayerGroup : CVector
    {
        public CHandle World { get; set; }
        public CHandle LayergroupParent { get; set; }
        public CDynamicInt NumGroups { get; set; }
        public CArray ChildrenGroups { get; set; }
        public CDynamicInt NumInfos { get; set; }
        public CArray ChildrenInfos { get; set; }

        public CLayerGroup(CR2WFile cr2w) : base(cr2w)
        {
            World = new CHandle(cr2w) { Name = "WorldParent" };
            LayergroupParent = new CHandle(cr2w) { Name = "LayergroupParent" };
            NumGroups = new CDynamicInt(cr2w);
            ChildrenGroups = new CArray(cr2w) { Name = "ChildrenGroups" };
            NumInfos = new CDynamicInt(cr2w);
            ChildrenInfos = new CArray(cr2w) { Name = "ChildrenInfos" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            // unknown bytes
            // first 4 bytes are a handle to the w2w resource
            World.ChunkHandle = true;
            World.val = file.ReadInt32();
            base.AddVariable(World);
            // next 4 bytes are a handle to the CLayerGroupParent (in the first case, this is 0)
            LayergroupParent.ChunkHandle = true;
            LayergroupParent.val = file.ReadInt32();
            base.AddVariable(LayergroupParent);

            // next are two arrays, with one-byte (of Type CDynamicInt?) length
            // first is an array of handles to all children of type CLayerGroup
            NumGroups.Read(file, 1);
            if (NumGroups.val > 0)
            {
                for (int i = 0; i < NumGroups.val; i++)
                {
                    var curhandle = new CHandle(base.cr2w)
                    {
                        ChunkHandle = true,
                        val = file.ReadInt32(),
                        Name = "LayerGroup",
                    };
                    ChildrenGroups.AddVariable(curhandle);
                }
                base.AddVariable(ChildrenGroups);
            }
            // second is an array of handles to all children of type CLayerGroup
            NumInfos.Read(file, 1);
            if (NumInfos.val > 0)
            {
                for (int i = 0; i < NumInfos.val; i++)
                {
                    var curhandle = new CHandle(base.cr2w)
                    {
                        ChunkHandle = true,
                        val = file.ReadInt32(),
                        Name = "LayerInfo",
                    };
                    ChildrenInfos.AddVariable(curhandle);
                }
                base.AddVariable(ChildrenInfos);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            // unknown bytes
            file.Write(World.val);
            file.Write(LayergroupParent.val);
            file.Write(NumGroups.ToByte());
            if (NumGroups.val > 0)
            {
                List<CVariable> list = ChildrenGroups.array;
                for (int i = 0; i < list.Count; i++)
                {
                    CHandle curHandle = (CHandle)list[i];
                    file.Write(curHandle.val);
                }
            }
            file.Write(NumInfos.ToByte());
            if (NumInfos.val > 0)
            {
                List<CVariable> list = ChildrenInfos.array;
                for (int i = 0; i < list.Count; i++)
                {
                    CHandle curHandle = (CHandle)list[i];
                    file.Write(curHandle.val);
                }
            }
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CLayerGroup(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CLayerGroup)base.Copy(context);

            var.World = (CHandle)World.Copy(context);
            var.LayergroupParent = (CHandle)LayergroupParent.Copy(context);
            var.NumGroups = (CDynamicInt)NumGroups.Copy(context);
            var.ChildrenGroups = (CArray)ChildrenGroups.Copy(context);
            var.NumInfos = (CDynamicInt)NumInfos.Copy(context);
            var.ChildrenInfos = (CArray)ChildrenInfos.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {

            };
            return list;
        }
    }
}
