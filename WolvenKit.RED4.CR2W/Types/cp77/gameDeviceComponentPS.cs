using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceComponentPS : gameComponentPS
	{
		private CBool _markAsQuest;
		private CBool _autoToggleQuestMark;
		private CName _factToDisableQuestMark;
		private CUInt32 _callbackToDisableQuestMarkID;
		private CHandle<BackDoorObjectiveData> _backdoorObjectiveData;
		private CHandle<ControlPanelObjectiveData> _controlPanelObjectiveData;
		private wCHandle<gameIBlackboard> _blackboard;
		private CBool _isScanned;
		private CBool _isBeingScanned;
		private CBool _exposeQuickHacks;
		private CBool _isAttachedToGame;
		private CBool _isLogicReady;

		[Ordinal(0)] 
		[RED("markAsQuest")] 
		public CBool MarkAsQuest
		{
			get
			{
				if (_markAsQuest == null)
				{
					_markAsQuest = (CBool) CR2WTypeManager.Create("Bool", "markAsQuest", cr2w, this);
				}
				return _markAsQuest;
			}
			set
			{
				if (_markAsQuest == value)
				{
					return;
				}
				_markAsQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("autoToggleQuestMark")] 
		public CBool AutoToggleQuestMark
		{
			get
			{
				if (_autoToggleQuestMark == null)
				{
					_autoToggleQuestMark = (CBool) CR2WTypeManager.Create("Bool", "autoToggleQuestMark", cr2w, this);
				}
				return _autoToggleQuestMark;
			}
			set
			{
				if (_autoToggleQuestMark == value)
				{
					return;
				}
				_autoToggleQuestMark = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("factToDisableQuestMark")] 
		public CName FactToDisableQuestMark
		{
			get
			{
				if (_factToDisableQuestMark == null)
				{
					_factToDisableQuestMark = (CName) CR2WTypeManager.Create("CName", "factToDisableQuestMark", cr2w, this);
				}
				return _factToDisableQuestMark;
			}
			set
			{
				if (_factToDisableQuestMark == value)
				{
					return;
				}
				_factToDisableQuestMark = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("callbackToDisableQuestMarkID")] 
		public CUInt32 CallbackToDisableQuestMarkID
		{
			get
			{
				if (_callbackToDisableQuestMarkID == null)
				{
					_callbackToDisableQuestMarkID = (CUInt32) CR2WTypeManager.Create("Uint32", "callbackToDisableQuestMarkID", cr2w, this);
				}
				return _callbackToDisableQuestMarkID;
			}
			set
			{
				if (_callbackToDisableQuestMarkID == value)
				{
					return;
				}
				_callbackToDisableQuestMarkID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("backdoorObjectiveData")] 
		public CHandle<BackDoorObjectiveData> BackdoorObjectiveData
		{
			get
			{
				if (_backdoorObjectiveData == null)
				{
					_backdoorObjectiveData = (CHandle<BackDoorObjectiveData>) CR2WTypeManager.Create("handle:BackDoorObjectiveData", "backdoorObjectiveData", cr2w, this);
				}
				return _backdoorObjectiveData;
			}
			set
			{
				if (_backdoorObjectiveData == value)
				{
					return;
				}
				_backdoorObjectiveData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("controlPanelObjectiveData")] 
		public CHandle<ControlPanelObjectiveData> ControlPanelObjectiveData
		{
			get
			{
				if (_controlPanelObjectiveData == null)
				{
					_controlPanelObjectiveData = (CHandle<ControlPanelObjectiveData>) CR2WTypeManager.Create("handle:ControlPanelObjectiveData", "controlPanelObjectiveData", cr2w, this);
				}
				return _controlPanelObjectiveData;
			}
			set
			{
				if (_controlPanelObjectiveData == value)
				{
					return;
				}
				_controlPanelObjectiveData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get
			{
				if (_isScanned == null)
				{
					_isScanned = (CBool) CR2WTypeManager.Create("Bool", "isScanned", cr2w, this);
				}
				return _isScanned;
			}
			set
			{
				if (_isScanned == value)
				{
					return;
				}
				_isScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isBeingScanned")] 
		public CBool IsBeingScanned
		{
			get
			{
				if (_isBeingScanned == null)
				{
					_isBeingScanned = (CBool) CR2WTypeManager.Create("Bool", "isBeingScanned", cr2w, this);
				}
				return _isBeingScanned;
			}
			set
			{
				if (_isBeingScanned == value)
				{
					return;
				}
				_isBeingScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("exposeQuickHacks")] 
		public CBool ExposeQuickHacks
		{
			get
			{
				if (_exposeQuickHacks == null)
				{
					_exposeQuickHacks = (CBool) CR2WTypeManager.Create("Bool", "exposeQuickHacks", cr2w, this);
				}
				return _exposeQuickHacks;
			}
			set
			{
				if (_exposeQuickHacks == value)
				{
					return;
				}
				_exposeQuickHacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isAttachedToGame")] 
		public CBool IsAttachedToGame
		{
			get
			{
				if (_isAttachedToGame == null)
				{
					_isAttachedToGame = (CBool) CR2WTypeManager.Create("Bool", "isAttachedToGame", cr2w, this);
				}
				return _isAttachedToGame;
			}
			set
			{
				if (_isAttachedToGame == value)
				{
					return;
				}
				_isAttachedToGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isLogicReady")] 
		public CBool IsLogicReady
		{
			get
			{
				if (_isLogicReady == null)
				{
					_isLogicReady = (CBool) CR2WTypeManager.Create("Bool", "isLogicReady", cr2w, this);
				}
				return _isLogicReady;
			}
			set
			{
				if (_isLogicReady == value)
				{
					return;
				}
				_isLogicReady = value;
				PropertySet(this);
			}
		}

		public gameDeviceComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
