using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToNode : scnSceneEvent
	{
		[Ordinal(6)] [RED("propId")] public scnPropId PropId { get; set; }
		[Ordinal(7)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(8)] [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(9)] [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }

		public scneventsAttachPropToNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
