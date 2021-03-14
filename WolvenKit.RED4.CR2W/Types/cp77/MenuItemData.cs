using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuItemData : IScriptable
	{
		private MenuData _menuData;

		[Ordinal(0)] 
		[RED("menuData")] 
		public MenuData MenuData
		{
			get
			{
				if (_menuData == null)
				{
					_menuData = (MenuData) CR2WTypeManager.Create("MenuData", "menuData", cr2w, this);
				}
				return _menuData;
			}
			set
			{
				if (_menuData == value)
				{
					return;
				}
				_menuData = value;
				PropertySet(this);
			}
		}

		public MenuItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
