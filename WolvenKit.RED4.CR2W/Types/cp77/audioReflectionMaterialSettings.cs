using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioReflectionMaterialSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("lowPass")] public CFloat LowPass { get; set; }
		[Ordinal(2)] [RED("highPass")] public CFloat HighPass { get; set; }
		[Ordinal(3)] [RED("gain")] public CFloat Gain { get; set; }

		public audioReflectionMaterialSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
