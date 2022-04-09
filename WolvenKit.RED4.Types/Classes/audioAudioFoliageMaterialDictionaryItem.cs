using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioFoliageMaterialDictionaryItem : audioInlinedAudioMetadata
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
		public audioAudioFoliageMaterial Value
		{
			get => GetPropertyValue<audioAudioFoliageMaterial>();
			set => SetPropertyValue<audioAudioFoliageMaterial>(value);
		}

		public audioAudioFoliageMaterialDictionaryItem()
		{
			Value = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
