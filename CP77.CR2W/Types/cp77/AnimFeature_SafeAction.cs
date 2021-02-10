using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SafeAction : animAnimFeature
	{
		[Ordinal(0)]  [RED("triggerHeld")] public CBool TriggerHeld { get; set; }
		[Ordinal(1)]  [RED("inCover")] public CBool InCover { get; set; }
		[Ordinal(2)]  [RED("safeActionDuration")] public CFloat SafeActionDuration { get; set; }

		public AnimFeature_SafeAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
