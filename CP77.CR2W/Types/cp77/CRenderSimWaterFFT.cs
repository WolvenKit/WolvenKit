using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CRenderSimWaterFFT : IDynamicTextureGenerator
	{
		[Ordinal(0)] [RED("windDir")] public CFloat WindDir { get; set; }
		[Ordinal(1)] [RED("windSpeed")] public CFloat WindSpeed { get; set; }
		[Ordinal(2)] [RED("windScale")] public CFloat WindScale { get; set; }
		[Ordinal(3)] [RED("amplitude")] public CFloat Amplitude { get; set; }
		[Ordinal(4)] [RED("lambda")] public CFloat Lambda { get; set; }

		public CRenderSimWaterFFT(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
