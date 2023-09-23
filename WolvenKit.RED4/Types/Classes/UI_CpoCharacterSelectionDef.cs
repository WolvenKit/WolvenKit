using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_CpoCharacterSelectionDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("SelectionMenuVisible")] 
		public gamebbScriptID_Bool SelectionMenuVisible
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("CharacterRecordId")] 
		public gamebbScriptID_Variant CharacterRecordId
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_CpoCharacterSelectionDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
