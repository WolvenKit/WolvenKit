using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class previewTargetStruct : CVariable
	{
		[Ordinal(0)] [RED("currentlyTrackedTarget")] public wCHandle<gameObject> CurrentlyTrackedTarget { get; set; }
		[Ordinal(1)] [RED("currentBodyPart")] public CEnum<EHitReactionZone> CurrentBodyPart { get; set; }

		public previewTargetStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
