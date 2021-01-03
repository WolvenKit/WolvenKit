using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalObstructionSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("absorptionPerMeter")] public CFloat AbsorptionPerMeter { get; set; }
		[Ordinal(1)]  [RED("initialAbsorbtion")] public CFloat InitialAbsorbtion { get; set; }

		public audioPhysicalObstructionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
