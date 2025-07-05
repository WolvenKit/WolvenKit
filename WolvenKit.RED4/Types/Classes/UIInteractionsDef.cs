using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInteractionsDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("InteractionChoiceHub")] 
		public gamebbScriptID_Variant InteractionChoiceHub
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("DialogChoiceHubs")] 
		public gamebbScriptID_Variant DialogChoiceHubs
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("LootData")] 
		public gamebbScriptID_Variant LootData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("ContactsData")] 
		public gamebbScriptID_Variant ContactsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(4)] 
		[RED("ActiveChoiceHubID")] 
		public gamebbScriptID_Int32 ActiveChoiceHubID
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(5)] 
		[RED("SelectedIndex")] 
		public gamebbScriptID_Int32 SelectedIndex
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(6)] 
		[RED("ActiveInteractions")] 
		public gamebbScriptID_Variant ActiveInteractions
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(7)] 
		[RED("InteractionSkillCheckHub")] 
		public gamebbScriptID_Variant InteractionSkillCheckHub
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(8)] 
		[RED("NameplateOwnerID")] 
		public gamebbScriptID_EntityID NameplateOwnerID
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(9)] 
		[RED("VisualizersInfo")] 
		public gamebbScriptID_Variant VisualizersInfo
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(10)] 
		[RED("ShouldHideClampedMappins")] 
		public gamebbScriptID_Bool ShouldHideClampedMappins
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(11)] 
		[RED("LastAttemptedChoice")] 
		public gamebbScriptID_Variant LastAttemptedChoice
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(12)] 
		[RED("LookAtTargetVisualizerID")] 
		public gamebbScriptID_Int32 LookAtTargetVisualizerID
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(13)] 
		[RED("HasScrollableInteraction")] 
		public gamebbScriptID_Bool HasScrollableInteraction
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(14)] 
		[RED("IsQuestNotificationUp")] 
		public gamebbScriptID_Bool IsQuestNotificationUp
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UIInteractionsDef()
		{
			InteractionChoiceHub = new gamebbScriptID_Variant();
			DialogChoiceHubs = new gamebbScriptID_Variant();
			LootData = new gamebbScriptID_Variant();
			ContactsData = new gamebbScriptID_Variant();
			ActiveChoiceHubID = new gamebbScriptID_Int32();
			SelectedIndex = new gamebbScriptID_Int32();
			ActiveInteractions = new gamebbScriptID_Variant();
			InteractionSkillCheckHub = new gamebbScriptID_Variant();
			NameplateOwnerID = new gamebbScriptID_EntityID();
			VisualizersInfo = new gamebbScriptID_Variant();
			ShouldHideClampedMappins = new gamebbScriptID_Bool();
			LastAttemptedChoice = new gamebbScriptID_Variant();
			LookAtTargetVisualizerID = new gamebbScriptID_Int32();
			HasScrollableInteraction = new gamebbScriptID_Bool();
			IsQuestNotificationUp = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
