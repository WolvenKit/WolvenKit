using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioContextualAudEventMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("context")] 
		public CName Context
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("event")] 
		public CName Event
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioContextualAudEventMapItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
