using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CRenderSimWaterFFT : IDynamicTextureGenerator
	{
		[Ordinal(0)]  [RED("amplitude")] public CFloat Amplitude { get; set; }
		[Ordinal(1)]  [RED("lambda")] public CFloat Lambda { get; set; }
		[Ordinal(2)]  [RED("windDir")] public CFloat WindDir { get; set; }
		[Ordinal(3)]  [RED("windScale")] public CFloat WindScale { get; set; }
		[Ordinal(4)]  [RED("windSpeed")] public CFloat WindSpeed { get; set; }

		public CRenderSimWaterFFT(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
