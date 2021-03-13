using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimatedSign : InteractiveDevice
	{
		[Ordinal(93)] [RED("animFeature")] public CHandle<AnimFeature_AnimatedDevice> AnimFeature { get; set; }

		public AnimatedSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
