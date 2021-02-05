using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToPerformer : scnSceneEvent
	{
		[Ordinal(0)]  [RED("propId")] public scnPropId PropId { get; set; }
		[Ordinal(1)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(2)]  [RED("slot")] public CName Slot { get; set; }
		[Ordinal(3)]  [RED("offsetMode")] public CEnum<scnOffsetMode> OffsetMode { get; set; }
		[Ordinal(4)]  [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(5)]  [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }

		public scneventsAttachPropToPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
