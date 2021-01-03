using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ColorGradingLutParams : CVariable
	{
		[Ordinal(0)]  [RED("LUT")] public rRef<CBitmapTexture> LUT { get; set; }
		[Ordinal(1)]  [RED("inputMapping")] public CEnum<EColorMappingFunction> InputMapping { get; set; }
		[Ordinal(2)]  [RED("outputMapping")] public CEnum<EColorMappingFunction> OutputMapping { get; set; }

		public ColorGradingLutParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
