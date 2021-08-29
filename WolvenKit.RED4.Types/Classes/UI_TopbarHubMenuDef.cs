using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_TopbarHubMenuDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isSubmenuHidden;
		private gamebbScriptID_Variant _metaQuestStatus;

		[Ordinal(0)] 
		[RED("IsSubmenuHidden")] 
		public gamebbScriptID_Bool IsSubmenuHidden
		{
			get => GetProperty(ref _isSubmenuHidden);
			set => SetProperty(ref _isSubmenuHidden, value);
		}

		[Ordinal(1)] 
		[RED("MetaQuestStatus")] 
		public gamebbScriptID_Variant MetaQuestStatus
		{
			get => GetProperty(ref _metaQuestStatus);
			set => SetProperty(ref _metaQuestStatus, value);
		}
	}
}
