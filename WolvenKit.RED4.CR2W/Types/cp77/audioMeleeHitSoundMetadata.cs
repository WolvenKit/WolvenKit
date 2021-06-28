using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeHitSoundMetadata : audioAudioMetadata
	{
		private CHandle<audioMaterialMeleeSoundDictionary> _meleeSoundsByMaterial;

		[Ordinal(1)] 
		[RED("meleeSoundsByMaterial")] 
		public CHandle<audioMaterialMeleeSoundDictionary> MeleeSoundsByMaterial
		{
			get => GetProperty(ref _meleeSoundsByMaterial);
			set => SetProperty(ref _meleeSoundsByMaterial, value);
		}

		public audioMeleeHitSoundMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
