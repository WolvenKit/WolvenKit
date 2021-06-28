using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_BaseMenu : inkMenuScenario
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

		public MenuScenario_BaseMenu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
