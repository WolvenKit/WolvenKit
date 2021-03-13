using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netInputOrientation : CVariable
	{
		[Ordinal(0)] [RED("yaw")] public CFloat Yaw { get; set; }
		[Ordinal(1)] [RED("pitch")] public CFloat Pitch { get; set; }

		public netInputOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
