using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotParamsV1 : questAICommandParams
	{
		private CEnum<questUseWorkspotNodeFunctions> _function;
		private NodeRef _workspotNode;
		private CBool _teleport;
		private CBool _finishAnimation;
		private CName _forceEntryAnimName;
		private CBool _jumpToEntry;
		private workWorkEntryId _entryId;
		private CName _entryTag;
		private CBool _changeWorkspot;
		private CBool _enableIdleMode;
		private workWorkEntryId _exitEntryId;
		private CName _exitAnimName;
		private CBool _instant;
		private CBool _isWorkspotInfinite;
		private CBool _isPlayer;
		private questUseWorkspotPlayerParams _playerParams;
		private CBool _repeatCommandOnInterrupt;
		private CArray<workWorkEntryId> _workExcludedGestures;
		private CEnum<moveMovementType> _movementType;
		private CBool _continueInCombat;
		private CFloat _maxAnimTimeLimit;

		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<questUseWorkspotNodeFunctions> Function
		{
			get
			{
				if (_function == null)
				{
					_function = (CEnum<questUseWorkspotNodeFunctions>) CR2WTypeManager.Create("questUseWorkspotNodeFunctions", "function", cr2w, this);
				}
				return _function;
			}
			set
			{
				if (_function == value)
				{
					return;
				}
				_function = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("workspotNode")] 
		public NodeRef WorkspotNode
		{
			get
			{
				if (_workspotNode == null)
				{
					_workspotNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "workspotNode", cr2w, this);
				}
				return _workspotNode;
			}
			set
			{
				if (_workspotNode == value)
				{
					return;
				}
				_workspotNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("teleport")] 
		public CBool Teleport
		{
			get
			{
				if (_teleport == null)
				{
					_teleport = (CBool) CR2WTypeManager.Create("Bool", "teleport", cr2w, this);
				}
				return _teleport;
			}
			set
			{
				if (_teleport == value)
				{
					return;
				}
				_teleport = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("finishAnimation")] 
		public CBool FinishAnimation
		{
			get
			{
				if (_finishAnimation == null)
				{
					_finishAnimation = (CBool) CR2WTypeManager.Create("Bool", "finishAnimation", cr2w, this);
				}
				return _finishAnimation;
			}
			set
			{
				if (_finishAnimation == value)
				{
					return;
				}
				_finishAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get
			{
				if (_forceEntryAnimName == null)
				{
					_forceEntryAnimName = (CName) CR2WTypeManager.Create("CName", "forceEntryAnimName", cr2w, this);
				}
				return _forceEntryAnimName;
			}
			set
			{
				if (_forceEntryAnimName == value)
				{
					return;
				}
				_forceEntryAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("jumpToEntry")] 
		public CBool JumpToEntry
		{
			get
			{
				if (_jumpToEntry == null)
				{
					_jumpToEntry = (CBool) CR2WTypeManager.Create("Bool", "jumpToEntry", cr2w, this);
				}
				return _jumpToEntry;
			}
			set
			{
				if (_jumpToEntry == value)
				{
					return;
				}
				_jumpToEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("entryId")] 
		public workWorkEntryId EntryId
		{
			get
			{
				if (_entryId == null)
				{
					_entryId = (workWorkEntryId) CR2WTypeManager.Create("workWorkEntryId", "entryId", cr2w, this);
				}
				return _entryId;
			}
			set
			{
				if (_entryId == value)
				{
					return;
				}
				_entryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("entryTag")] 
		public CName EntryTag
		{
			get
			{
				if (_entryTag == null)
				{
					_entryTag = (CName) CR2WTypeManager.Create("CName", "entryTag", cr2w, this);
				}
				return _entryTag;
			}
			set
			{
				if (_entryTag == value)
				{
					return;
				}
				_entryTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("changeWorkspot")] 
		public CBool ChangeWorkspot
		{
			get
			{
				if (_changeWorkspot == null)
				{
					_changeWorkspot = (CBool) CR2WTypeManager.Create("Bool", "changeWorkspot", cr2w, this);
				}
				return _changeWorkspot;
			}
			set
			{
				if (_changeWorkspot == value)
				{
					return;
				}
				_changeWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("enableIdleMode")] 
		public CBool EnableIdleMode
		{
			get
			{
				if (_enableIdleMode == null)
				{
					_enableIdleMode = (CBool) CR2WTypeManager.Create("Bool", "enableIdleMode", cr2w, this);
				}
				return _enableIdleMode;
			}
			set
			{
				if (_enableIdleMode == value)
				{
					return;
				}
				_enableIdleMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("exitEntryId")] 
		public workWorkEntryId ExitEntryId
		{
			get
			{
				if (_exitEntryId == null)
				{
					_exitEntryId = (workWorkEntryId) CR2WTypeManager.Create("workWorkEntryId", "exitEntryId", cr2w, this);
				}
				return _exitEntryId;
			}
			set
			{
				if (_exitEntryId == value)
				{
					return;
				}
				_exitEntryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("exitAnimName")] 
		public CName ExitAnimName
		{
			get
			{
				if (_exitAnimName == null)
				{
					_exitAnimName = (CName) CR2WTypeManager.Create("CName", "exitAnimName", cr2w, this);
				}
				return _exitAnimName;
			}
			set
			{
				if (_exitAnimName == value)
				{
					return;
				}
				_exitAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("instant")] 
		public CBool Instant
		{
			get
			{
				if (_instant == null)
				{
					_instant = (CBool) CR2WTypeManager.Create("Bool", "instant", cr2w, this);
				}
				return _instant;
			}
			set
			{
				if (_instant == value)
				{
					return;
				}
				_instant = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isWorkspotInfinite")] 
		public CBool IsWorkspotInfinite
		{
			get
			{
				if (_isWorkspotInfinite == null)
				{
					_isWorkspotInfinite = (CBool) CR2WTypeManager.Create("Bool", "isWorkspotInfinite", cr2w, this);
				}
				return _isWorkspotInfinite;
			}
			set
			{
				if (_isWorkspotInfinite == value)
				{
					return;
				}
				_isWorkspotInfinite = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("playerParams")] 
		public questUseWorkspotPlayerParams PlayerParams
		{
			get
			{
				if (_playerParams == null)
				{
					_playerParams = (questUseWorkspotPlayerParams) CR2WTypeManager.Create("questUseWorkspotPlayerParams", "playerParams", cr2w, this);
				}
				return _playerParams;
			}
			set
			{
				if (_playerParams == value)
				{
					return;
				}
				_playerParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get
			{
				if (_repeatCommandOnInterrupt == null)
				{
					_repeatCommandOnInterrupt = (CBool) CR2WTypeManager.Create("Bool", "repeatCommandOnInterrupt", cr2w, this);
				}
				return _repeatCommandOnInterrupt;
			}
			set
			{
				if (_repeatCommandOnInterrupt == value)
				{
					return;
				}
				_repeatCommandOnInterrupt = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("workExcludedGestures")] 
		public CArray<workWorkEntryId> WorkExcludedGestures
		{
			get
			{
				if (_workExcludedGestures == null)
				{
					_workExcludedGestures = (CArray<workWorkEntryId>) CR2WTypeManager.Create("array:workWorkEntryId", "workExcludedGestures", cr2w, this);
				}
				return _workExcludedGestures;
			}
			set
			{
				if (_workExcludedGestures == value)
				{
					return;
				}
				_workExcludedGestures = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CEnum<moveMovementType>) CR2WTypeManager.Create("moveMovementType", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("continueInCombat")] 
		public CBool ContinueInCombat
		{
			get
			{
				if (_continueInCombat == null)
				{
					_continueInCombat = (CBool) CR2WTypeManager.Create("Bool", "continueInCombat", cr2w, this);
				}
				return _continueInCombat;
			}
			set
			{
				if (_continueInCombat == value)
				{
					return;
				}
				_continueInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("maxAnimTimeLimit")] 
		public CFloat MaxAnimTimeLimit
		{
			get
			{
				if (_maxAnimTimeLimit == null)
				{
					_maxAnimTimeLimit = (CFloat) CR2WTypeManager.Create("Float", "maxAnimTimeLimit", cr2w, this);
				}
				return _maxAnimTimeLimit;
			}
			set
			{
				if (_maxAnimTimeLimit == value)
				{
					return;
				}
				_maxAnimTimeLimit = value;
				PropertySet(this);
			}
		}

		public questUseWorkspotParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
