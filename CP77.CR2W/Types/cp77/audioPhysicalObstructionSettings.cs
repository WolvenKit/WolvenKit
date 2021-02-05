using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalObstructionSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("initialAbsorbtion")] public CFloat InitialAbsorbtion { get; set; }
		[Ordinal(1)]  [RED("absorptionPerMeter")] public CFloat AbsorptionPerMeter { get; set; }

		public audioPhysicalObstructionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
