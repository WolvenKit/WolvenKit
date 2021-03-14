using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalObstructionSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("initialAbsorbtion")] public CFloat InitialAbsorbtion { get; set; }
		[Ordinal(2)] [RED("absorptionPerMeter")] public CFloat AbsorptionPerMeter { get; set; }

		public audioPhysicalObstructionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
