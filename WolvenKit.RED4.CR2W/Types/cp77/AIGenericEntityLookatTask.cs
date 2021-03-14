using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGenericEntityLookatTask : AIGenericLookatTask
	{
		[Ordinal(0)] [RED("lookAtEvent")] public CHandle<entLookAtAddEvent> LookAtEvent { get; set; }
		[Ordinal(1)] [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(2)] [RED("lookatTarget")] public wCHandle<entEntity> LookatTarget { get; set; }

		public AIGenericEntityLookatTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
