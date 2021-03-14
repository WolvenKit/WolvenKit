using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ItemModSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemModSystemUpdated;

		[Ordinal(0)] 
		[RED("ItemModSystemUpdated")] 
		public gamebbScriptID_Variant ItemModSystemUpdated
		{
			get
			{
				if (_itemModSystemUpdated == null)
				{
					_itemModSystemUpdated = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ItemModSystemUpdated", cr2w, this);
				}
				return _itemModSystemUpdated;
			}
			set
			{
				if (_itemModSystemUpdated == value)
				{
					return;
				}
				_itemModSystemUpdated = value;
				PropertySet(this);
			}
		}

		public UI_ItemModSystemDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
