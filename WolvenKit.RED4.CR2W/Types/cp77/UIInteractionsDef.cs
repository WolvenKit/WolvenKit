using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInteractionsDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _interactionChoiceHub;
		private gamebbScriptID_Variant _dialogChoiceHubs;
		private gamebbScriptID_Variant _lootData;
		private gamebbScriptID_Variant _contactsData;
		private gamebbScriptID_Int32 _activeChoiceHubID;
		private gamebbScriptID_Int32 _selectedIndex;
		private gamebbScriptID_Variant _activeInteractions;
		private gamebbScriptID_Variant _interactionSkillCheckHub;
		private gamebbScriptID_EntityID _nameplateOwnerID;
		private gamebbScriptID_Variant _visualizersInfo;
		private gamebbScriptID_Bool _shouldHideClampedMappins;
		private gamebbScriptID_Variant _lastAttemptedChoice;
		private gamebbScriptID_Int32 _lookAtTargetVisualizerID;
		private gamebbScriptID_Bool _hasScrollableInteraction;

		[Ordinal(0)] 
		[RED("InteractionChoiceHub")] 
		public gamebbScriptID_Variant InteractionChoiceHub
		{
			get => GetProperty(ref _interactionChoiceHub);
			set => SetProperty(ref _interactionChoiceHub, value);
		}

		[Ordinal(1)] 
		[RED("DialogChoiceHubs")] 
		public gamebbScriptID_Variant DialogChoiceHubs
		{
			get => GetProperty(ref _dialogChoiceHubs);
			set => SetProperty(ref _dialogChoiceHubs, value);
		}

		[Ordinal(2)] 
		[RED("LootData")] 
		public gamebbScriptID_Variant LootData
		{
			get => GetProperty(ref _lootData);
			set => SetProperty(ref _lootData, value);
		}

		[Ordinal(3)] 
		[RED("ContactsData")] 
		public gamebbScriptID_Variant ContactsData
		{
			get => GetProperty(ref _contactsData);
			set => SetProperty(ref _contactsData, value);
		}

		[Ordinal(4)] 
		[RED("ActiveChoiceHubID")] 
		public gamebbScriptID_Int32 ActiveChoiceHubID
		{
			get => GetProperty(ref _activeChoiceHubID);
			set => SetProperty(ref _activeChoiceHubID, value);
		}

		[Ordinal(5)] 
		[RED("SelectedIndex")] 
		public gamebbScriptID_Int32 SelectedIndex
		{
			get => GetProperty(ref _selectedIndex);
			set => SetProperty(ref _selectedIndex, value);
		}

		[Ordinal(6)] 
		[RED("ActiveInteractions")] 
		public gamebbScriptID_Variant ActiveInteractions
		{
			get => GetProperty(ref _activeInteractions);
			set => SetProperty(ref _activeInteractions, value);
		}

		[Ordinal(7)] 
		[RED("InteractionSkillCheckHub")] 
		public gamebbScriptID_Variant InteractionSkillCheckHub
		{
			get => GetProperty(ref _interactionSkillCheckHub);
			set => SetProperty(ref _interactionSkillCheckHub, value);
		}

		[Ordinal(8)] 
		[RED("NameplateOwnerID")] 
		public gamebbScriptID_EntityID NameplateOwnerID
		{
			get => GetProperty(ref _nameplateOwnerID);
			set => SetProperty(ref _nameplateOwnerID, value);
		}

		[Ordinal(9)] 
		[RED("VisualizersInfo")] 
		public gamebbScriptID_Variant VisualizersInfo
		{
			get => GetProperty(ref _visualizersInfo);
			set => SetProperty(ref _visualizersInfo, value);
		}

		[Ordinal(10)] 
		[RED("ShouldHideClampedMappins")] 
		public gamebbScriptID_Bool ShouldHideClampedMappins
		{
			get => GetProperty(ref _shouldHideClampedMappins);
			set => SetProperty(ref _shouldHideClampedMappins, value);
		}

		[Ordinal(11)] 
		[RED("LastAttemptedChoice")] 
		public gamebbScriptID_Variant LastAttemptedChoice
		{
			get => GetProperty(ref _lastAttemptedChoice);
			set => SetProperty(ref _lastAttemptedChoice, value);
		}

		[Ordinal(12)] 
		[RED("LookAtTargetVisualizerID")] 
		public gamebbScriptID_Int32 LookAtTargetVisualizerID
		{
			get => GetProperty(ref _lookAtTargetVisualizerID);
			set => SetProperty(ref _lookAtTargetVisualizerID, value);
		}

		[Ordinal(13)] 
		[RED("HasScrollableInteraction")] 
		public gamebbScriptID_Bool HasScrollableInteraction
		{
			get => GetProperty(ref _hasScrollableInteraction);
			set => SetProperty(ref _hasScrollableInteraction, value);
		}

		public UIInteractionsDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
