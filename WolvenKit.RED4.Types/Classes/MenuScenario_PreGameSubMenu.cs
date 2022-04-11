using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_PreGameSubMenu : inkMenuScenario
	{
		[Ordinal(0)] 
		[RED("prevScenario")] 
		public CName PrevScenario
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("currSubMenuName")] 
		public CName CurrSubMenuName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
