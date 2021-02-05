using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioShockwaveGlobalSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("explosionPropagationSpeed")] public CFloat ExplosionPropagationSpeed { get; set; }
		[Ordinal(1)]  [RED("thumpPropagationSpeed")] public CFloat ThumpPropagationSpeed { get; set; }
		[Ordinal(2)]  [RED("electroshockPropagationSpeed")] public CFloat ElectroshockPropagationSpeed { get; set; }
		[Ordinal(3)]  [RED("revealPropagationSpeed")] public CFloat RevealPropagationSpeed { get; set; }

		public audioShockwaveGlobalSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
