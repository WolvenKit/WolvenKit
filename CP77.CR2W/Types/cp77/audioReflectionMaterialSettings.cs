using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioReflectionMaterialSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("gain")] public CFloat Gain { get; set; }
		[Ordinal(1)]  [RED("highPass")] public CFloat HighPass { get; set; }
		[Ordinal(2)]  [RED("lowPass")] public CFloat LowPass { get; set; }

		public audioReflectionMaterialSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
