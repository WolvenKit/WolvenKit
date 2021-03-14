using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionUIBase : gameuiHUDGameController
	{
		private CHandle<gameIBlackboard> _interactionsBlackboard;
		private CHandle<UIInteractionsDef> _interactionsBBDefinition;
		private CUInt32 _dialogsDataListenerId;
		private CUInt32 _dialogsActiveHubListenerId;
		private CUInt32 _dialogsSelectedChoiceListenerId;
		private CUInt32 _interactionsDataListenerId;
		private CUInt32 _lootingDataListenerId;
		private CBool _areDialogsOpen;
		private CBool _areContactsOpen;
		private CBool _isLootingOpen;
		private CBool _areInteractionsOpen;
		private CBool _interactionIsScrollable;
		private CBool _dialogIsScrollable;
		private CBool _lootingIsScrollable;

		[Ordinal(9)] 
		[RED("InteractionsBlackboard")] 
		public CHandle<gameIBlackboard> InteractionsBlackboard
		{
			get
			{
				if (_interactionsBlackboard == null)
				{
					_interactionsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "InteractionsBlackboard", cr2w, this);
				}
				return _interactionsBlackboard;
			}
			set
			{
				if (_interactionsBlackboard == value)
				{
					return;
				}
				_interactionsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("InteractionsBBDefinition")] 
		public CHandle<UIInteractionsDef> InteractionsBBDefinition
		{
			get
			{
				if (_interactionsBBDefinition == null)
				{
					_interactionsBBDefinition = (CHandle<UIInteractionsDef>) CR2WTypeManager.Create("handle:UIInteractionsDef", "InteractionsBBDefinition", cr2w, this);
				}
				return _interactionsBBDefinition;
			}
			set
			{
				if (_interactionsBBDefinition == value)
				{
					return;
				}
				_interactionsBBDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("DialogsDataListenerId")] 
		public CUInt32 DialogsDataListenerId
		{
			get
			{
				if (_dialogsDataListenerId == null)
				{
					_dialogsDataListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "DialogsDataListenerId", cr2w, this);
				}
				return _dialogsDataListenerId;
			}
			set
			{
				if (_dialogsDataListenerId == value)
				{
					return;
				}
				_dialogsDataListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("DialogsActiveHubListenerId")] 
		public CUInt32 DialogsActiveHubListenerId
		{
			get
			{
				if (_dialogsActiveHubListenerId == null)
				{
					_dialogsActiveHubListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "DialogsActiveHubListenerId", cr2w, this);
				}
				return _dialogsActiveHubListenerId;
			}
			set
			{
				if (_dialogsActiveHubListenerId == value)
				{
					return;
				}
				_dialogsActiveHubListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("DialogsSelectedChoiceListenerId")] 
		public CUInt32 DialogsSelectedChoiceListenerId
		{
			get
			{
				if (_dialogsSelectedChoiceListenerId == null)
				{
					_dialogsSelectedChoiceListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "DialogsSelectedChoiceListenerId", cr2w, this);
				}
				return _dialogsSelectedChoiceListenerId;
			}
			set
			{
				if (_dialogsSelectedChoiceListenerId == value)
				{
					return;
				}
				_dialogsSelectedChoiceListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("InteractionsDataListenerId")] 
		public CUInt32 InteractionsDataListenerId
		{
			get
			{
				if (_interactionsDataListenerId == null)
				{
					_interactionsDataListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "InteractionsDataListenerId", cr2w, this);
				}
				return _interactionsDataListenerId;
			}
			set
			{
				if (_interactionsDataListenerId == value)
				{
					return;
				}
				_interactionsDataListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("lootingDataListenerId")] 
		public CUInt32 LootingDataListenerId
		{
			get
			{
				if (_lootingDataListenerId == null)
				{
					_lootingDataListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "lootingDataListenerId", cr2w, this);
				}
				return _lootingDataListenerId;
			}
			set
			{
				if (_lootingDataListenerId == value)
				{
					return;
				}
				_lootingDataListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("AreDialogsOpen")] 
		public CBool AreDialogsOpen
		{
			get
			{
				if (_areDialogsOpen == null)
				{
					_areDialogsOpen = (CBool) CR2WTypeManager.Create("Bool", "AreDialogsOpen", cr2w, this);
				}
				return _areDialogsOpen;
			}
			set
			{
				if (_areDialogsOpen == value)
				{
					return;
				}
				_areDialogsOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("AreContactsOpen")] 
		public CBool AreContactsOpen
		{
			get
			{
				if (_areContactsOpen == null)
				{
					_areContactsOpen = (CBool) CR2WTypeManager.Create("Bool", "AreContactsOpen", cr2w, this);
				}
				return _areContactsOpen;
			}
			set
			{
				if (_areContactsOpen == value)
				{
					return;
				}
				_areContactsOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("IsLootingOpen")] 
		public CBool IsLootingOpen
		{
			get
			{
				if (_isLootingOpen == null)
				{
					_isLootingOpen = (CBool) CR2WTypeManager.Create("Bool", "IsLootingOpen", cr2w, this);
				}
				return _isLootingOpen;
			}
			set
			{
				if (_isLootingOpen == value)
				{
					return;
				}
				_isLootingOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("AreInteractionsOpen")] 
		public CBool AreInteractionsOpen
		{
			get
			{
				if (_areInteractionsOpen == null)
				{
					_areInteractionsOpen = (CBool) CR2WTypeManager.Create("Bool", "AreInteractionsOpen", cr2w, this);
				}
				return _areInteractionsOpen;
			}
			set
			{
				if (_areInteractionsOpen == value)
				{
					return;
				}
				_areInteractionsOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("interactionIsScrollable")] 
		public CBool InteractionIsScrollable
		{
			get
			{
				if (_interactionIsScrollable == null)
				{
					_interactionIsScrollable = (CBool) CR2WTypeManager.Create("Bool", "interactionIsScrollable", cr2w, this);
				}
				return _interactionIsScrollable;
			}
			set
			{
				if (_interactionIsScrollable == value)
				{
					return;
				}
				_interactionIsScrollable = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("dialogIsScrollable")] 
		public CBool DialogIsScrollable
		{
			get
			{
				if (_dialogIsScrollable == null)
				{
					_dialogIsScrollable = (CBool) CR2WTypeManager.Create("Bool", "dialogIsScrollable", cr2w, this);
				}
				return _dialogIsScrollable;
			}
			set
			{
				if (_dialogIsScrollable == value)
				{
					return;
				}
				_dialogIsScrollable = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("lootingIsScrollable")] 
		public CBool LootingIsScrollable
		{
			get
			{
				if (_lootingIsScrollable == null)
				{
					_lootingIsScrollable = (CBool) CR2WTypeManager.Create("Bool", "lootingIsScrollable", cr2w, this);
				}
				return _lootingIsScrollable;
			}
			set
			{
				if (_lootingIsScrollable == value)
				{
					return;
				}
				_lootingIsScrollable = value;
				PropertySet(this);
			}
		}

		public InteractionUIBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
