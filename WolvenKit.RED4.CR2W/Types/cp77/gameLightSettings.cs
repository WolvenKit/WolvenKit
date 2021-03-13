using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLightSettings : CVariable
	{
		[Ordinal(0)] [RED("strength")] public CFloat Strength { get; set; }
		[Ordinal(1)] [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(2)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(3)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(4)] [RED("innerAngle")] public CFloat InnerAngle { get; set; }
		[Ordinal(5)] [RED("outerAngle")] public CFloat OuterAngle { get; set; }

		public gameLightSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
