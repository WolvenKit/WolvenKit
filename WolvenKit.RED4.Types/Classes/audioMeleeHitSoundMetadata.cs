using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeHitSoundMetadata : audioAudioMetadata
	{
		private CHandle<audioMaterialMeleeSoundDictionary> _meleeSoundsByMaterial;

		[Ordinal(1)] 
		[RED("meleeSoundsByMaterial")] 
		public CHandle<audioMaterialMeleeSoundDictionary> MeleeSoundsByMaterial
		{
			get => GetProperty(ref _meleeSoundsByMaterial);
			set => SetProperty(ref _meleeSoundsByMaterial, value);
		}
	}
}
