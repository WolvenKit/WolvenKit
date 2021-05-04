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
			get => GetProperty(ref _selectionMenuVisible);
			set => SetProperty(ref _selectionMenuVisible, value);
		}

		[Ordinal(1)] 
		[RED("CharacterRecordId")] 
		public gamebbScriptID_Variant CharacterRecordId
		{
			get => GetProperty(ref _characterRecordId);
			set => SetProperty(ref _characterRecordId, value);
		}

		public UI_CpoCharacterSelectionDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
