using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioEventPrefetchStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<questAudioEventPrefetchMode> Mode
		{
			get => GetPropertyValue<CEnum<questAudioEventPrefetchMode>>();
			set => SetPropertyValue<CEnum<questAudioEventPrefetchMode>>(value);
		}

		public questAudioEventPrefetchStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
