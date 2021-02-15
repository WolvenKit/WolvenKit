using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIGenericAdvancedLookatTask : AIGenericLookatTask
	{
		[Ordinal(0)] [RED("lookAtEvent")] public CHandle<entLookAtAddEvent> LookAtEvent { get; set; }
		[Ordinal(1)] [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(2)] [RED("lookatTarget")] public wCHandle<entEntity> LookatTarget { get; set; }

		public AIGenericAdvancedLookatTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
