
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
    public class CLayerInfo : ISerializable
    {
        [RED("tags")] public TagList Tags { get; set; }

        [RED("layerType")] public ELayerType LayerType { get; set; }

        [RED("layerBuildTag")] public ELayerBuildTag LayerBuildTag { get; set; }

        [RED("layerMergeContentMode")] public ELayerMergedContent LayerMergeContentMode { get; set; }

        [RED("streamingLayer")] public CBool StreamingLayer { get; set; }

        [RED("depotFilePath")] public CString DepotFilePath { get; set; }

        [RED("shortName")] public CString ShortName { get; set; }

        [RED("guid")] public CGUID Guid { get; set; }

        [RED("hasEmbeddedLayerInfo")] public CBool HasEmbeddedLayerInfo { get; set; }

        [REDBuffer(true)] public CHandle<CLayerGroup> ParentGroup { get; set; }

        public CLayerInfo(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            ParentGroup.ChunkHandle = true;
            ParentGroup.Read(file, 4);

            //base.AddVariable(ParentGroup);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            ParentGroup.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CLayerInfo(cr2w);
        }

        
    }
}
