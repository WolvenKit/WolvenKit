using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioShockwaveGlobalSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("explosionPropagationSpeed")] public CFloat ExplosionPropagationSpeed { get; set; }
		[Ordinal(2)] [RED("thumpPropagationSpeed")] public CFloat ThumpPropagationSpeed { get; set; }
		[Ordinal(3)] [RED("electroshockPropagationSpeed")] public CFloat ElectroshockPropagationSpeed { get; set; }
		[Ordinal(4)] [RED("revealPropagationSpeed")] public CFloat RevealPropagationSpeed { get; set; }

		public audioShockwaveGlobalSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
