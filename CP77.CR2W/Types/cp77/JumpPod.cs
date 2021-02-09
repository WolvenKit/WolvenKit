using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JumpPod : gameObject
	{
		[Ordinal(31)]  [RED("activationLight")] public CHandle<entIVisualComponent> ActivationLight { get; set; }
		[Ordinal(32)]  [RED("activationTrigger")] public CHandle<entIComponent> ActivationTrigger { get; set; }
		[Ordinal(33)]  [RED("impulseForward")] public CFloat ImpulseForward { get; set; }
		[Ordinal(34)]  [RED("impulseRight")] public CFloat ImpulseRight { get; set; }
		[Ordinal(35)]  [RED("impulseUp")] public CFloat ImpulseUp { get; set; }

		public JumpPod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
