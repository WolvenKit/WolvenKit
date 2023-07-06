using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMaterialMeleeSoundDictionaryItem : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public audioMeleeSound Value
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		public audioMaterialMeleeSoundDictionaryItem()
		{
			Value = new audioMeleeSound { Events = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
