using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SimpleSwitch : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("animationSpeed")] public CFloat AnimationSpeed { get; set; }
		[Ordinal(1)]  [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }

		public SimpleSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
