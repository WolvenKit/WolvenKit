using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioMeleeHitSoundMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("meleeSoundsByMaterial")] public CHandle<audioMaterialMeleeSoundDictionary> MeleeSoundsByMaterial { get; set; }

		public audioMeleeHitSoundMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
