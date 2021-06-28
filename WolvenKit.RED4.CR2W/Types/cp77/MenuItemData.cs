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
			get => GetProperty(ref _menuData);
			set => SetProperty(ref _menuData, value);
		}

		public MenuItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
