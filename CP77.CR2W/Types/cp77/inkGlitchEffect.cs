using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkGlitchEffect : inkIEffect
	{
		[Ordinal(0)]  [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(1)]  [RED("offsetX")] public CFloat OffsetX { get; set; }
		[Ordinal(2)]  [RED("offsetY")] public CFloat OffsetY { get; set; }
		[Ordinal(3)]  [RED("sizeX")] public CFloat SizeX { get; set; }
		[Ordinal(4)]  [RED("sizeY")] public CFloat SizeY { get; set; }

		public inkGlitchEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
