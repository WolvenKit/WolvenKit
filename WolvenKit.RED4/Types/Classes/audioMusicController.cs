using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMusicController : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("playEvent")] 
		public CName PlayEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("stopEvent")] 
		public CName StopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("muteEvent")] 
		public CName MuteEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("unmuteEvent")] 
		public CName UnmuteEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioMusicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
