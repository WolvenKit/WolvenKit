using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeHitSoundMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("meleeSoundsByMaterial")] 
		public CHandle<audioMaterialMeleeSoundDictionary> MeleeSoundsByMaterial
		{
			get => GetPropertyValue<CHandle<audioMaterialMeleeSoundDictionary>>();
			set => SetPropertyValue<CHandle<audioMaterialMeleeSoundDictionary>>(value);
		}

		public audioMeleeHitSoundMetadata()
		{
			MeleeSoundsByMaterial = new audioMaterialMeleeSoundDictionary { EntryType = new audioMaterialMeleeSoundDictionaryItem() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
