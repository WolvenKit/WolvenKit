using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_BaseMenu : inkMenuScenario
	{
		private CName _currMenuName;
		private CHandle<IScriptable> _currUserData;
		private CName _currSubMenuName;
		private CName _prevMenuName;

		[Ordinal(0)] 
		[RED("currMenuName")] 
		public CName CurrMenuName
		{
			get => GetProperty(ref _currMenuName);
			set => SetProperty(ref _currMenuName, value);
		}

		[Ordinal(1)] 
		[RED("currUserData")] 
		public CHandle<IScriptable> CurrUserData
		{
			get => GetProperty(ref _currUserData);
			set => SetProperty(ref _currUserData, value);
		}

		[Ordinal(2)] 
		[RED("currSubMenuName")] 
		public CName CurrSubMenuName
		{
			get => GetProperty(ref _currSubMenuName);
			set => SetProperty(ref _currSubMenuName, value);
		}

		[Ordinal(3)] 
		[RED("prevMenuName")] 
		public CName PrevMenuName
		{
			get => GetProperty(ref _prevMenuName);
			set => SetProperty(ref _prevMenuName, value);
		}
	}
}
