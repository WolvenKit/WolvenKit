using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLoopingSoundController : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("playEvent")] 
		public CName PlayEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("preStopEvent")] 
		public CName PreStopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("stopEvent")] 
		public CName StopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioLoopingSoundController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
