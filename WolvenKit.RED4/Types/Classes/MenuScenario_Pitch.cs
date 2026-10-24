using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuScenario_Pitch : MenuScenario_PreGameSubMenu
	{
		[Ordinal(2)] 
		[RED("fallbackScenario")] 
		public CName FallbackScenario
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public MenuScenario_Pitch()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
