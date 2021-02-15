using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkInnerGlowEffect : inkIEffect
	{
		[Ordinal(2)] [RED("colorR")] public CFloat ColorR { get; set; }
		[Ordinal(3)] [RED("colorG")] public CFloat ColorG { get; set; }
		[Ordinal(4)] [RED("colorB")] public CFloat ColorB { get; set; }
		[Ordinal(5)] [RED("colorA")] public CFloat ColorA { get; set; }
		[Ordinal(6)] [RED("offsetX")] public CFloat OffsetX { get; set; }
		[Ordinal(7)] [RED("offsetY")] public CFloat OffsetY { get; set; }

		public inkInnerGlowEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
