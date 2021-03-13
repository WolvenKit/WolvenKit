using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("command")] public CHandle<AIBackgroundCombatCommand> Command { get; set; }
		[Ordinal(1)] [RED("execute")] public CBool Execute { get; set; }
		[Ordinal(2)] [RED("steps")] public CArray<AIBackgroundCombatStep> Steps { get; set; }
		[Ordinal(3)] [RED("currentStep")] public CInt32 CurrentStep { get; set; }
		[Ordinal(4)] [RED("desiredCover")] public NodeRef DesiredCover { get; set; }
		[Ordinal(5)] [RED("desiredCoverExposureMethod")] public CEnum<AICoverExposureMethod> DesiredCoverExposureMethod { get; set; }
		[Ordinal(6)] [RED("desiredDestination")] public NodeRef DesiredDestination { get; set; }
		[Ordinal(7)] [RED("hasDesiredTarget")] public CBool HasDesiredTarget { get; set; }
		[Ordinal(8)] [RED("desiredTarget")] public gameEntityReference DesiredTarget { get; set; }
		[Ordinal(9)] [RED("desiredCoverId")] public CUInt64 DesiredCoverId { get; set; }
		[Ordinal(10)] [RED("currentCoverId")] public CUInt64 CurrentCoverId { get; set; }
		[Ordinal(11)] [RED("currentTarget")] public wCHandle<gameObject> CurrentTarget { get; set; }
		[Ordinal(12)] [RED("canFireFromCover")] public CBool CanFireFromCover { get; set; }
		[Ordinal(13)] [RED("canFireOutOfCover")] public CBool CanFireOutOfCover { get; set; }

		public AIBackgroundCombatDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
