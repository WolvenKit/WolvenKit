using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CpoCharacterSelectionDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _selectionMenuVisible;
		private gamebbScriptID_Variant _characterRecordId;

		[Ordinal(0)] 
		[RED("SelectionMenuVisible")] 
		public gamebbScriptID_Bool SelectionMenuVisible
		{
			get
			{
				if (_selectionMenuVisible == null)
				{
					_selectionMenuVisible = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "SelectionMenuVisible", cr2w, this);
				}
				return _selectionMenuVisible;
			}
			set
			{
				if (_selectionMenuVisible == value)
				{
					return;
				}
				_selectionMenuVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("CharacterRecordId")] 
		public gamebbScriptID_Variant CharacterRecordId
		{
			get
			{
				if (_characterRecordId == null)
				{
					_characterRecordId = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "CharacterRecordId", cr2w, this);
				}
				return _characterRecordId;
			}
			set
			{
				if (_characterRecordId == value)
				{
					return;
				}
				_characterRecordId = value;
				PropertySet(this);
			}
		}

		public UI_CpoCharacterSelectionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
