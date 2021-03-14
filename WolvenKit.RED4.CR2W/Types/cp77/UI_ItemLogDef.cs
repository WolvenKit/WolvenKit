using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ItemLogDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemLogItem;

		[Ordinal(0)] 
		[RED("ItemLogItem")] 
		public gamebbScriptID_Variant ItemLogItem
		{
			get
			{
				if (_itemLogItem == null)
				{
					_itemLogItem = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ItemLogItem", cr2w, this);
				}
				return _itemLogItem;
			}
			set
			{
				if (_itemLogItem == value)
				{
					return;
				}
				_itemLogItem = value;
				PropertySet(this);
			}
		}

		public UI_ItemLogDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
