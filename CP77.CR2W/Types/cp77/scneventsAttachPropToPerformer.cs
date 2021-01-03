using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToPerformer : scnSceneEvent
	{
		[Ordinal(0)]  [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(1)]  [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }
		[Ordinal(2)]  [RED("offsetMode")] public CEnum<scnOffsetMode> OffsetMode { get; set; }
		[Ordinal(3)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(4)]  [RED("propId")] public scnPropId PropId { get; set; }
		[Ordinal(5)]  [RED("slot")] public CName Slot { get; set; }

		public scneventsAttachPropToPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
