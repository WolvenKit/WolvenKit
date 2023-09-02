using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioKeyUiControlPairDictionaryItem : audioInlinedAudioMetadata
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
		public audioUiControl Value
		{
			get => GetPropertyValue<audioUiControl>();
			set => SetPropertyValue<audioUiControl>(value);
		}

		public audioKeyUiControlPairDictionaryItem()
		{
			Value = new audioUiControl();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
