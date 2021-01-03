using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class previewTargetStruct : CVariable
	{
		[Ordinal(0)]  [RED("currentBodyPart")] public CEnum<EHitReactionZone> CurrentBodyPart { get; set; }
		[Ordinal(1)]  [RED("currentlyTrackedTarget")] public wCHandle<gameObject> CurrentlyTrackedTarget { get; set; }

		public previewTargetStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
