using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_PreGameSubMenu : inkMenuScenario
	{
		private CName _prevScenario;
		private CName _currSubMenuName;

		[Ordinal(0)] 
		[RED("prevScenario")] 
		public CName PrevScenario
		{
			get => GetProperty(ref _prevScenario);
			set => SetProperty(ref _prevScenario, value);
		}

		[Ordinal(1)] 
		[RED("currSubMenuName")] 
		public CName CurrSubMenuName
		{
			get => GetProperty(ref _currSubMenuName);
			set => SetProperty(ref _currSubMenuName, value);
		}
	}
}
