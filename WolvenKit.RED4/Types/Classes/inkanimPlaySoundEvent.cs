using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimPlaySoundEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("soundEventName")] 
		public CName SoundEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkanimPlaySoundEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
