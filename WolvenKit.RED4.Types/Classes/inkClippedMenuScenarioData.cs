using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkClippedMenuScenarioData : IScriptable
	{
		private CArray<CName> _menus;

		[Ordinal(0)] 
		[RED("menus")] 
		public CArray<CName> Menus
		{
			get => GetProperty(ref _menus);
			set => SetProperty(ref _menus, value);
		}
	}
}
