using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_CpoCharacterSelectionDef : gamebbScriptDefinition
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
	}
}
