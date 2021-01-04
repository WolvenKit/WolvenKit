using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVision_ConditionType : questISensesConditionType
	{
		[Ordinal(0)]  [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(1)]  [RED("isInstant")] public CBool IsInstant { get; set; }
		[Ordinal(2)]  [RED("isObservedTargetPlayer")] public CBool IsObservedTargetPlayer { get; set; }
		[Ordinal(3)]  [RED("observedTargetRef")] public gameEntityReference ObservedTargetRef { get; set; }
		[Ordinal(4)]  [RED("observerPuppetRef")] public gameEntityReference ObserverPuppetRef { get; set; }

		public questVision_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
