using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuItemData : IScriptable
	{
		private MenuData _menuData;

		[Ordinal(0)] 
		[RED("menuData")] 
		public MenuData MenuData
		{
			get => GetProperty(ref _menuData);
			set => SetProperty(ref _menuData, value);
		}
	}
}
