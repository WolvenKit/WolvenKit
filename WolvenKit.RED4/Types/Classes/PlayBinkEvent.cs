using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayBinkEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public SBinkperationData Data
		{
			get => GetPropertyValue<SBinkperationData>();
			set => SetPropertyValue<SBinkperationData>(value);
		}

		public PlayBinkEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
