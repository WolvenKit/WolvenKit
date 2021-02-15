using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLightSweepEffect : inkIEffect
	{
		[Ordinal(2)] [RED("positionX")] public CFloat PositionX { get; set; }
		[Ordinal(3)] [RED("positionY")] public CFloat PositionY { get; set; }
		[Ordinal(4)] [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(5)] [RED("width")] public CFloat Width { get; set; }
		[Ordinal(6)] [RED("intensity")] public CFloat Intensity { get; set; }

		public inkLightSweepEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
