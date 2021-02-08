using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnbExternalLayer : IMaterial
	{
		[Ordinal(0)]  [RED("scenePath")] public CString scenePath { get; set; }
		[Ordinal(1)]  [RED("layerName")] public CString layerName { get; set; }
		[Ordinal(2)]  [RED("layerEvents")] public CArray<scnbExternalLayerEventData> layerEvents { get; set; }


        public scnbExternalLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class scnbExternalLayerEventData : CVariable
    {
        [Ordinal(0)] [RED("trackName")] public CString trackName { get; set; }
        [Ordinal(1)] [RED("nodeId")] public scnNodeId nodeId { get; set; }
        [Ordinal(2)] [RED("parentTrackId")] public toolsSceneTrackID parentTrackId { get; set; }
        [Ordinal(3)] [RED("event")] public CHandle<toolsEventDescriptor> event_ { get; set; }
        


        public scnbExternalLayerEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class toolsSceneTrackID : CVariable
    {
        [Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }
        

        public toolsSceneTrackID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class scnbPerformerInScene_NodeType : CVariable
    {
        [Ordinal(0)] [RED("action")] public CEnum<populationSpawnerObjectCtrlAction> action { get; set; }
        [Ordinal(1)] [RED("performer")] public CRUID performer { get; set; }
        [Ordinal(2)] [RED("performerAcquisitionPlanType")] public CEnum<scnbPerformerAcquisitionPlanType> performerAcquisitionPlanType { get; set; }
        [Ordinal(3)] [RED("reference")] public NodeRef reference { get; set; }
        [Ordinal(4)] [RED("entryName")] public CName entryName { get; set; }
        [Ordinal(5)] [RED("template")] public rRef<communityCommunityTemplate> template { get; set; }
        [Ordinal(6)] [RED("phaseName")] public CName phaseName { get; set; }

        public scnbPerformerInScene_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class toolsEventDescriptor : CVariable
    {
        public toolsEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

}
