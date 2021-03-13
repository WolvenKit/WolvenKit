using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MountRequestPassiveCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)] [RED("unmountRequest")] public CBool UnmountRequest { get; set; }
		[Ordinal(1)] [RED("acceptInstant")] public CBool AcceptInstant { get; set; }
		[Ordinal(2)] [RED("acceptNotInstant")] public CBool AcceptNotInstant { get; set; }
		[Ordinal(3)] [RED("acceptForcedTransition")] public CBool AcceptForcedTransition { get; set; }
		[Ordinal(4)] [RED("callbackId")] public CUInt32 CallbackId { get; set; }
		[Ordinal(5)] [RED("highLevelStateCallbackId")] public CUInt32 HighLevelStateCallbackId { get; set; }

		public MountRequestPassiveCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
