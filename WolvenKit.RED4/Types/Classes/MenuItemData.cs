using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			MenuData = new MenuData { Identifier = -1, SubMenus = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
