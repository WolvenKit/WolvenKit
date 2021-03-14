using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interactionWidgetGameController : gameuiHUDGameController
	{
		private wCHandle<inkWidget> _root;
		private wCHandle<inkTextWidget> _titleLabel;
		private wCHandle<inkWidget> _titleBorder;
		private wCHandle<inkHorizontalPanelWidget> _optionsList;
		private CArray<wCHandle<inkWidget>> _widgetsPool;
		private CHandle<gameIBlackboard> _bbInteraction;
		private CHandle<gameIBlackboard> _bbPlayerStateMachine;
		private CHandle<UIInteractionsDef> _bbInteractionDefinition;
		private CUInt32 _updateInteractionId;
		private CUInt32 _activeHubListenerId;
		private CUInt32 _contactsActiveListenerId;
		private CInt32 _id;
		private CBool _isActive;
		private CBool _areContactsOpen;
		private inkWidgetReference _progressBarHolder;
		private CHandle<DialogChoiceTimerController> _progressBar;
		private CBool _hasProgressBar;
		private CHandle<gameIBlackboard> _bb;
		private CHandle<UIInteractionsDef> _bbUIInteractionsDef;
		private CUInt32 _bbLastAttemptedChoiceCallbackId;

		[Ordinal(9)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("titleLabel")] 
		public wCHandle<inkTextWidget> TitleLabel
		{
			get
			{
				if (_titleLabel == null)
				{
					_titleLabel = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "titleLabel", cr2w, this);
				}
				return _titleLabel;
			}
			set
			{
				if (_titleLabel == value)
				{
					return;
				}
				_titleLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("titleBorder")] 
		public wCHandle<inkWidget> TitleBorder
		{
			get
			{
				if (_titleBorder == null)
				{
					_titleBorder = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "titleBorder", cr2w, this);
				}
				return _titleBorder;
			}
			set
			{
				if (_titleBorder == value)
				{
					return;
				}
				_titleBorder = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("optionsList")] 
		public wCHandle<inkHorizontalPanelWidget> OptionsList
		{
			get
			{
				if (_optionsList == null)
				{
					_optionsList = (wCHandle<inkHorizontalPanelWidget>) CR2WTypeManager.Create("whandle:inkHorizontalPanelWidget", "optionsList", cr2w, this);
				}
				return _optionsList;
			}
			set
			{
				if (_optionsList == value)
				{
					return;
				}
				_optionsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("widgetsPool")] 
		public CArray<wCHandle<inkWidget>> WidgetsPool
		{
			get
			{
				if (_widgetsPool == null)
				{
					_widgetsPool = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "widgetsPool", cr2w, this);
				}
				return _widgetsPool;
			}
			set
			{
				if (_widgetsPool == value)
				{
					return;
				}
				_widgetsPool = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bbInteraction")] 
		public CHandle<gameIBlackboard> BbInteraction
		{
			get
			{
				if (_bbInteraction == null)
				{
					_bbInteraction = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbInteraction", cr2w, this);
				}
				return _bbInteraction;
			}
			set
			{
				if (_bbInteraction == value)
				{
					return;
				}
				_bbInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bbPlayerStateMachine")] 
		public CHandle<gameIBlackboard> BbPlayerStateMachine
		{
			get
			{
				if (_bbPlayerStateMachine == null)
				{
					_bbPlayerStateMachine = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbPlayerStateMachine", cr2w, this);
				}
				return _bbPlayerStateMachine;
			}
			set
			{
				if (_bbPlayerStateMachine == value)
				{
					return;
				}
				_bbPlayerStateMachine = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("bbInteractionDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionDefinition
		{
			get
			{
				if (_bbInteractionDefinition == null)
				{
					_bbInteractionDefinition = (CHandle<UIInteractionsDef>) CR2WTypeManager.Create("handle:UIInteractionsDef", "bbInteractionDefinition", cr2w, this);
				}
				return _bbInteractionDefinition;
			}
			set
			{
				if (_bbInteractionDefinition == value)
				{
					return;
				}
				_bbInteractionDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("updateInteractionId")] 
		public CUInt32 UpdateInteractionId
		{
			get
			{
				if (_updateInteractionId == null)
				{
					_updateInteractionId = (CUInt32) CR2WTypeManager.Create("Uint32", "updateInteractionId", cr2w, this);
				}
				return _updateInteractionId;
			}
			set
			{
				if (_updateInteractionId == value)
				{
					return;
				}
				_updateInteractionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("activeHubListenerId")] 
		public CUInt32 ActiveHubListenerId
		{
			get
			{
				if (_activeHubListenerId == null)
				{
					_activeHubListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "activeHubListenerId", cr2w, this);
				}
				return _activeHubListenerId;
			}
			set
			{
				if (_activeHubListenerId == value)
				{
					return;
				}
				_activeHubListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("contactsActiveListenerId")] 
		public CUInt32 ContactsActiveListenerId
		{
			get
			{
				if (_contactsActiveListenerId == null)
				{
					_contactsActiveListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "contactsActiveListenerId", cr2w, this);
				}
				return _contactsActiveListenerId;
			}
			set
			{
				if (_contactsActiveListenerId == value)
				{
					return;
				}
				_contactsActiveListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("areContactsOpen")] 
		public CBool AreContactsOpen
		{
			get
			{
				if (_areContactsOpen == null)
				{
					_areContactsOpen = (CBool) CR2WTypeManager.Create("Bool", "areContactsOpen", cr2w, this);
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

		[Ordinal(23)] 
		[RED("progressBarHolder")] 
		public inkWidgetReference ProgressBarHolder
		{
			get
			{
				if (_progressBarHolder == null)
				{
					_progressBarHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBarHolder", cr2w, this);
				}
				return _progressBarHolder;
			}
			set
			{
				if (_progressBarHolder == value)
				{
					return;
				}
				_progressBarHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("progressBar")] 
		public CHandle<DialogChoiceTimerController> ProgressBar
		{
			get
			{
				if (_progressBar == null)
				{
					_progressBar = (CHandle<DialogChoiceTimerController>) CR2WTypeManager.Create("handle:DialogChoiceTimerController", "progressBar", cr2w, this);
				}
				return _progressBar;
			}
			set
			{
				if (_progressBar == value)
				{
					return;
				}
				_progressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("hasProgressBar")] 
		public CBool HasProgressBar
		{
			get
			{
				if (_hasProgressBar == null)
				{
					_hasProgressBar = (CBool) CR2WTypeManager.Create("Bool", "hasProgressBar", cr2w, this);
				}
				return _hasProgressBar;
			}
			set
			{
				if (_hasProgressBar == value)
				{
					return;
				}
				_hasProgressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("bb")] 
		public CHandle<gameIBlackboard> Bb
		{
			get
			{
				if (_bb == null)
				{
					_bb = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bb", cr2w, this);
				}
				return _bb;
			}
			set
			{
				if (_bb == value)
				{
					return;
				}
				_bb = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("bbUIInteractionsDef")] 
		public CHandle<UIInteractionsDef> BbUIInteractionsDef
		{
			get
			{
				if (_bbUIInteractionsDef == null)
				{
					_bbUIInteractionsDef = (CHandle<UIInteractionsDef>) CR2WTypeManager.Create("handle:UIInteractionsDef", "bbUIInteractionsDef", cr2w, this);
				}
				return _bbUIInteractionsDef;
			}
			set
			{
				if (_bbUIInteractionsDef == value)
				{
					return;
				}
				_bbUIInteractionsDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("bbLastAttemptedChoiceCallbackId")] 
		public CUInt32 BbLastAttemptedChoiceCallbackId
		{
			get
			{
				if (_bbLastAttemptedChoiceCallbackId == null)
				{
					_bbLastAttemptedChoiceCallbackId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbLastAttemptedChoiceCallbackId", cr2w, this);
				}
				return _bbLastAttemptedChoiceCallbackId;
			}
			set
			{
				if (_bbLastAttemptedChoiceCallbackId == value)
				{
					return;
				}
				_bbLastAttemptedChoiceCallbackId = value;
				PropertySet(this);
			}
		}

		public interactionWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
