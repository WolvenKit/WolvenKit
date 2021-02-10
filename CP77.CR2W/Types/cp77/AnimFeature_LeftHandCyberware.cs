using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LeftHandCyberware : animAnimFeature
	{
		[Ordinal(0)]  [RED("actionDuration")] public CFloat ActionDuration { get; set; }
		[Ordinal(1)]  [RED("state")] public CInt32 State { get; set; }
		[Ordinal(2)]  [RED("isQuickAction")] public CBool IsQuickAction { get; set; }
		[Ordinal(3)]  [RED("isChargeAction")] public CBool IsChargeAction { get; set; }
		[Ordinal(4)]  [RED("isLoopAction")] public CBool IsLoopAction { get; set; }
		[Ordinal(5)]  [RED("isCatchAction")] public CBool IsCatchAction { get; set; }
		[Ordinal(6)]  [RED("isSafeAction")] public CBool IsSafeAction { get; set; }

		public AnimFeature_LeftHandCyberware(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
