using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_EquipmentDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemEquipped;
		private gamebbScriptID_Variant _lastModifiedArea;

		[Ordinal(0)] 
		[RED("itemEquipped")] 
		public gamebbScriptID_Variant ItemEquipped
		{
			get
			{
				if (_itemEquipped == null)
				{
					_itemEquipped = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "itemEquipped", cr2w, this);
				}
				return _itemEquipped;
			}
			set
			{
				if (_itemEquipped == value)
				{
					return;
				}
				_itemEquipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lastModifiedArea")] 
		public gamebbScriptID_Variant LastModifiedArea
		{
			get
			{
				if (_lastModifiedArea == null)
				{
					_lastModifiedArea = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "lastModifiedArea", cr2w, this);
				}
				return _lastModifiedArea;
			}
			set
			{
				if (_lastModifiedArea == value)
				{
					return;
				}
				_lastModifiedArea = value;
				PropertySet(this);
			}
		}

		public UI_EquipmentDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
