using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLightSweepEffect : inkIEffect
	{
		[Ordinal(0)]  [RED("positionX")] public CFloat PositionX { get; set; }
		[Ordinal(1)]  [RED("positionY")] public CFloat PositionY { get; set; }
		[Ordinal(2)]  [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(3)]  [RED("width")] public CFloat Width { get; set; }
		[Ordinal(4)]  [RED("intensity")] public CFloat Intensity { get; set; }

		public inkLightSweepEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
