using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class JumpPod : gameObject
	{
		[Ordinal(0)]  [RED("activationLight")] public CHandle<entIVisualComponent> ActivationLight { get; set; }
		[Ordinal(1)]  [RED("activationTrigger")] public CHandle<entIComponent> ActivationTrigger { get; set; }
		[Ordinal(2)]  [RED("impulseForward")] public CFloat ImpulseForward { get; set; }
		[Ordinal(3)]  [RED("impulseRight")] public CFloat ImpulseRight { get; set; }
		[Ordinal(4)]  [RED("impulseUp")] public CFloat ImpulseUp { get; set; }

		public JumpPod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
