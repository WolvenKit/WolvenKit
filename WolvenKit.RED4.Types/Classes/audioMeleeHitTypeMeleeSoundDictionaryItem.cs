using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeHitTypeMeleeSoundDictionaryItem : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("key")] 
		public CEnum<audioMeleeHitPerMaterialType> Key
		{
			get => GetPropertyValue<CEnum<audioMeleeHitPerMaterialType>>();
			set => SetPropertyValue<CEnum<audioMeleeHitPerMaterialType>>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public audioMeleeSound Value
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		public audioMeleeHitTypeMeleeSoundDictionaryItem()
		{
			Value = new() { Events = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
