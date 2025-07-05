using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeLightByNameEvent : ChangeLightEvent
	{
		[Ordinal(4)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ChangeLightByNameEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
