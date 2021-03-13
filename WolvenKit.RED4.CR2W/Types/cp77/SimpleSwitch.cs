using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleSwitch : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(94)] [RED("animationSpeed")] public CFloat AnimationSpeed { get; set; }

		public SimpleSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
