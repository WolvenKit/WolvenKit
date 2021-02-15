using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToPerformer : scnSceneEvent
	{
		[Ordinal(6)] [RED("propId")] public scnPropId PropId { get; set; }
		[Ordinal(7)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(8)] [RED("slot")] public CName Slot { get; set; }
		[Ordinal(9)] [RED("offsetMode")] public CEnum<scnOffsetMode> OffsetMode { get; set; }
		[Ordinal(10)] [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(11)] [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }

		public scneventsAttachPropToPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
