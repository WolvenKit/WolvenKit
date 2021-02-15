using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkGlitchEffect : inkIEffect
	{
		[Ordinal(2)] [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(3)] [RED("offsetX")] public CFloat OffsetX { get; set; }
		[Ordinal(4)] [RED("offsetY")] public CFloat OffsetY { get; set; }
		[Ordinal(5)] [RED("sizeX")] public CFloat SizeX { get; set; }
		[Ordinal(6)] [RED("sizeY")] public CFloat SizeY { get; set; }

		public inkGlitchEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
