using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("menuData")] 
		public MenuData MenuData
		{
			get => GetPropertyValue<MenuData>();
			set => SetPropertyValue<MenuData>(value);
		}

		public MenuItemData()
		{
			MenuData = new() { Identifier = -1, SubMenus = new() };
		}
	}
}
