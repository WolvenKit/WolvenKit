using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class localizationPersistenceSubtitleMapEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("subtitleGroup")] 
		public CName SubtitleGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("subtitleFile")] 
		public CResourceAsyncReference<JsonResource> SubtitleFile
		{
			get => GetPropertyValue<CResourceAsyncReference<JsonResource>>();
			set => SetPropertyValue<CResourceAsyncReference<JsonResource>>(value);
		}

		public localizationPersistenceSubtitleMapEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
