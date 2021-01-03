using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioShockwaveGlobalSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("electroshockPropagationSpeed")] public CFloat ElectroshockPropagationSpeed { get; set; }
		[Ordinal(1)]  [RED("explosionPropagationSpeed")] public CFloat ExplosionPropagationSpeed { get; set; }
		[Ordinal(2)]  [RED("revealPropagationSpeed")] public CFloat RevealPropagationSpeed { get; set; }
		[Ordinal(3)]  [RED("thumpPropagationSpeed")] public CFloat ThumpPropagationSpeed { get; set; }

		public audioShockwaveGlobalSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
