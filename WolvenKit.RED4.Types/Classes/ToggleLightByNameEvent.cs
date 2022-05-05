using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleLightByNameEvent : ToggleLightEvent
	{
		[Ordinal(2)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ToggleLightByNameEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
