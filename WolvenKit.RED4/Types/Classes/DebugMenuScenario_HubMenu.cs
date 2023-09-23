using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DebugMenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		[Ordinal(4)] 
		[RED("defaultMenu")] 
		public CName DefaultMenu
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("cpoDefaultMenu")] 
		public CName CpoDefaultMenu
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DebugMenuScenario_HubMenu()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
