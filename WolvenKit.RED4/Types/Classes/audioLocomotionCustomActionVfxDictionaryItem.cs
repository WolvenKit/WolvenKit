using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLocomotionCustomActionVfxDictionaryItem : audioInlinedAudioMetadata
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
		public CResourceAsyncReference<CResource> Value
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		public audioLocomotionCustomActionVfxDictionaryItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
