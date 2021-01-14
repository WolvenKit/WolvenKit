using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIGenericStaticLookatTask : AIGenericLookatTask
	{
		[Ordinal(0)]  [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(1)]  [RED("currentLookatTarget")] public Vector4 CurrentLookatTarget { get; set; }
		[Ordinal(2)]  [RED("lookAtEvent")] public CHandle<entLookAtAddEvent> LookAtEvent { get; set; }
		[Ordinal(3)]  [RED("lookatTarget")] public Vector4 LookatTarget { get; set; }

		public AIGenericStaticLookatTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
