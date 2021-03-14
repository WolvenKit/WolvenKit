using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HudTooltipDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemId;
		private gamebbScriptID_Bool _showTooltip;

		[Ordinal(0)] 
		[RED("ItemId")] 
		public gamebbScriptID_Variant ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ItemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ShowTooltip")] 
		public gamebbScriptID_Bool ShowTooltip
		{
			get
			{
				if (_showTooltip == null)
				{
					_showTooltip = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ShowTooltip", cr2w, this);
				}
				return _showTooltip;
			}
			set
			{
				if (_showTooltip == value)
				{
					return;
				}
				_showTooltip = value;
				PropertySet(this);
			}
		}

		public UI_HudTooltipDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
