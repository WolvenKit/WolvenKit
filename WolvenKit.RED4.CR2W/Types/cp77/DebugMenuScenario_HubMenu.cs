using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugMenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		private CName _defaultMenu;
		private CName _cpoDefaultMenu;

		[Ordinal(4)] 
		[RED("defaultMenu")] 
		public CName DefaultMenu
		{
			get => GetProperty(ref _defaultMenu);
			set => SetProperty(ref _defaultMenu, value);
		}

		[Ordinal(5)] 
		[RED("cpoDefaultMenu")] 
		public CName CpoDefaultMenu
		{
			get => GetProperty(ref _cpoDefaultMenu);
			set => SetProperty(ref _cpoDefaultMenu, value);
		}

		public DebugMenuScenario_HubMenu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
