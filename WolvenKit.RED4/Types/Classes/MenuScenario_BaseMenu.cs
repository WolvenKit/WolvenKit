using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuScenario_BaseMenu : inkMenuScenario
	{
		[Ordinal(0)] 
		[RED("currMenuName")] 
		public CName CurrMenuName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("currUserData")] 
		public CHandle<IScriptable> CurrUserData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		[Ordinal(2)] 
		[RED("currSubMenuName")] 
		public CName CurrSubMenuName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("prevMenuName")] 
		public CName PrevMenuName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public MenuScenario_BaseMenu()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
