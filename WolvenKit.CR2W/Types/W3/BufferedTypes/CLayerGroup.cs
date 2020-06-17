
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CLayerGroup : ISerializable
    {
        [RED("name")] public CString Name { get; set; }

        [RED("depotPath")] public CString DepotPath { get; set; }

        [RED("absolutePath")] public CString AbsolutePath { get; set; }

        [RED("isVisibleOnStart")] public CBool IsVisibleOnStart { get; set; }

        [RED("systemGroup")] public CBool SystemGroup { get; set; }

        [RED("hasEmbeddedLayerInfos")] public CBool HasEmbeddedLayerInfos { get; set; }

        [RED("idHash")] public CUInt64 IdHash { get; set; }

        [REDBuffer] public CHandle<CGameWorld> worldhandle { get; set; }
        [REDBuffer] public CHandle<CLayerGroup> layergrouphandle { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CLayerGroup>> childrenGroups { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CLayerGroup>> childrenInfos { get; set; }

        public CLayerGroup(CR2WFile cr2w) : base(cr2w)
        {
            
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

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CLayerGroup(cr2w);
        }

        
    }
}
