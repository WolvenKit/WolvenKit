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
			get
			{
				if (_interactionChoiceHub == null)
				{
					_interactionChoiceHub = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "InteractionChoiceHub", cr2w, this);
				}
				return _interactionChoiceHub;
			}
			set
			{
				if (_interactionChoiceHub == value)
				{
					return;
				}
				_interactionChoiceHub = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("DialogChoiceHubs")] 
		public gamebbScriptID_Variant DialogChoiceHubs
		{
			get
			{
				if (_dialogChoiceHubs == null)
				{
					_dialogChoiceHubs = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DialogChoiceHubs", cr2w, this);
				}
				return _dialogChoiceHubs;
			}
			set
			{
				if (_dialogChoiceHubs == value)
				{
					return;
				}
				_dialogChoiceHubs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("LootData")] 
		public gamebbScriptID_Variant LootData
		{
			get
			{
				if (_lootData == null)
				{
					_lootData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "LootData", cr2w, this);
				}
				return _lootData;
			}
			set
			{
				if (_lootData == value)
				{
					return;
				}
				_lootData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ContactsData")] 
		public gamebbScriptID_Variant ContactsData
		{
			get
			{
				if (_contactsData == null)
				{
					_contactsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ContactsData", cr2w, this);
				}
				return _contactsData;
			}
			set
			{
				if (_contactsData == value)
				{
					return;
				}
				_contactsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ActiveChoiceHubID")] 
		public gamebbScriptID_Int32 ActiveChoiceHubID
		{
			get
			{
				if (_activeChoiceHubID == null)
				{
					_activeChoiceHubID = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ActiveChoiceHubID", cr2w, this);
				}
				return _activeChoiceHubID;
			}
			set
			{
				if (_activeChoiceHubID == value)
				{
					return;
				}
				_activeChoiceHubID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("SelectedIndex")] 
		public gamebbScriptID_Int32 SelectedIndex
		{
			get
			{
				if (_selectedIndex == null)
				{
					_selectedIndex = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "SelectedIndex", cr2w, this);
				}
				return _selectedIndex;
			}
			set
			{
				if (_selectedIndex == value)
				{
					return;
				}
				_selectedIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ActiveInteractions")] 
		public gamebbScriptID_Variant ActiveInteractions
		{
			get
			{
				if (_activeInteractions == null)
				{
					_activeInteractions = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ActiveInteractions", cr2w, this);
				}
				return _activeInteractions;
			}
			set
			{
				if (_activeInteractions == value)
				{
					return;
				}
				_activeInteractions = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("InteractionSkillCheckHub")] 
		public gamebbScriptID_Variant InteractionSkillCheckHub
		{
			get
			{
				if (_interactionSkillCheckHub == null)
				{
					_interactionSkillCheckHub = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "InteractionSkillCheckHub", cr2w, this);
				}
				return _interactionSkillCheckHub;
			}
			set
			{
				if (_interactionSkillCheckHub == value)
				{
					return;
				}
				_interactionSkillCheckHub = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("NameplateOwnerID")] 
		public gamebbScriptID_EntityID NameplateOwnerID
		{
			get
			{
				if (_nameplateOwnerID == null)
				{
					_nameplateOwnerID = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "NameplateOwnerID", cr2w, this);
				}
				return _nameplateOwnerID;
			}
			set
			{
				if (_nameplateOwnerID == value)
				{
					return;
				}
				_nameplateOwnerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("VisualizersInfo")] 
		public gamebbScriptID_Variant VisualizersInfo
		{
			get
			{
				if (_visualizersInfo == null)
				{
					_visualizersInfo = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "VisualizersInfo", cr2w, this);
				}
				return _visualizersInfo;
			}
			set
			{
				if (_visualizersInfo == value)
				{
					return;
				}
				_visualizersInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ShouldHideClampedMappins")] 
		public gamebbScriptID_Bool ShouldHideClampedMappins
		{
			get
			{
				if (_shouldHideClampedMappins == null)
				{
					_shouldHideClampedMappins = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ShouldHideClampedMappins", cr2w, this);
				}
				return _shouldHideClampedMappins;
			}
			set
			{
				if (_shouldHideClampedMappins == value)
				{
					return;
				}
				_shouldHideClampedMappins = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("LastAttemptedChoice")] 
		public gamebbScriptID_Variant LastAttemptedChoice
		{
			get
			{
				if (_lastAttemptedChoice == null)
				{
					_lastAttemptedChoice = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "LastAttemptedChoice", cr2w, this);
				}
				return _lastAttemptedChoice;
			}
			set
			{
				if (_lastAttemptedChoice == value)
				{
					return;
				}
				_lastAttemptedChoice = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("LookAtTargetVisualizerID")] 
		public gamebbScriptID_Int32 LookAtTargetVisualizerID
		{
			get
			{
				if (_lookAtTargetVisualizerID == null)
				{
					_lookAtTargetVisualizerID = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "LookAtTargetVisualizerID", cr2w, this);
				}
				return _lookAtTargetVisualizerID;
			}
			set
			{
				if (_lookAtTargetVisualizerID == value)
				{
					return;
				}
				_lookAtTargetVisualizerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("HasScrollableInteraction")] 
		public gamebbScriptID_Bool HasScrollableInteraction
		{
			get
			{
				if (_hasScrollableInteraction == null)
				{
					_hasScrollableInteraction = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "HasScrollableInteraction", cr2w, this);
				}
				return _hasScrollableInteraction;
			}
			set
			{
				if (_hasScrollableInteraction == value)
				{
					return;
				}
				_hasScrollableInteraction = value;
				PropertySet(this);
			}
		}

		public UIInteractionsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
