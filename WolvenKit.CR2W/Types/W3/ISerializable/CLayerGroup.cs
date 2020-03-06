
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class CLayerGroup : CVector
    {
        public CHandle worldhandle { get; set; }
        public CHandle layergrouphandle { get; set; }
        public CBufferVLQ<CHandle> childrenGroups { get; set; }
        public CBufferVLQ<CHandle> childrenInfos { get; set; }

        public CLayerGroup(CR2WFile cr2w) : base(cr2w)
        {
            worldhandle = new CHandle(cr2w) { Name = "worldhandle", ChunkHandle = true };
            layergrouphandle = new CHandle(cr2w) { Name = "layergrouphandle", ChunkHandle = true };
            childrenGroups = new CBufferVLQ<CHandle>(cr2w, _ => new CHandle(_) { ChunkHandle = true }) { Name = "ChildrenGroups" };
            childrenInfos = new CBufferVLQ<CHandle>(cr2w, _ => new CHandle(_) { ChunkHandle = true }) { Name = "ChildrenInfos" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            worldhandle.Read(file, size);
            layergrouphandle.Read(file, size);
            childrenGroups.Read(file, size);
            childrenInfos.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            worldhandle.Write(file);
            layergrouphandle.Write(file);
            childrenGroups.Write(file);
            childrenInfos.Write(file);
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

            var.worldhandle = (CHandle)worldhandle.Copy(context);
            var.layergrouphandle = (CHandle)layergrouphandle.Copy(context);
            var.childrenGroups = (CBufferVLQ<CHandle>)childrenGroups.Copy(context);
            var.childrenInfos = (CBufferVLQ<CHandle>)childrenInfos.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                worldhandle,
                layergrouphandle,
                childrenGroups,
                childrenInfos
            };
            return list;
        }
    }
}
