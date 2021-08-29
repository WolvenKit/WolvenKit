using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DebugMenuScenario_HubMenu : MenuScenario_BaseMenu
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
	}
}
