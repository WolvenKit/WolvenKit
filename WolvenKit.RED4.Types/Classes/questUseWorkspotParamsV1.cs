using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUseWorkspotParamsV1 : questAICommandParams
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
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}

		[Ordinal(1)] 
		[RED("workspotNode")] 
		public NodeRef WorkspotNode
		{
			get => GetProperty(ref _workspotNode);
			set => SetProperty(ref _workspotNode, value);
		}

		[Ordinal(2)] 
		[RED("teleport")] 
		public CBool Teleport
		{
			get => GetProperty(ref _teleport);
			set => SetProperty(ref _teleport, value);
		}

		[Ordinal(3)] 
		[RED("finishAnimation")] 
		public CBool FinishAnimation
		{
			get => GetProperty(ref _finishAnimation);
			set => SetProperty(ref _finishAnimation, value);
		}

		[Ordinal(4)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get => GetProperty(ref _forceEntryAnimName);
			set => SetProperty(ref _forceEntryAnimName, value);
		}

		[Ordinal(5)] 
		[RED("jumpToEntry")] 
		public CBool JumpToEntry
		{
			get => GetProperty(ref _jumpToEntry);
			set => SetProperty(ref _jumpToEntry, value);
		}

		[Ordinal(6)] 
		[RED("entryId")] 
		public workWorkEntryId EntryId
		{
			get => GetProperty(ref _entryId);
			set => SetProperty(ref _entryId, value);
		}

		[Ordinal(7)] 
		[RED("entryTag")] 
		public CName EntryTag
		{
			get => GetProperty(ref _entryTag);
			set => SetProperty(ref _entryTag, value);
		}

		[Ordinal(8)] 
		[RED("changeWorkspot")] 
		public CBool ChangeWorkspot
		{
			get => GetProperty(ref _changeWorkspot);
			set => SetProperty(ref _changeWorkspot, value);
		}

		[Ordinal(9)] 
		[RED("enableIdleMode")] 
		public CBool EnableIdleMode
		{
			get => GetProperty(ref _enableIdleMode);
			set => SetProperty(ref _enableIdleMode, value);
		}

		[Ordinal(10)] 
		[RED("exitEntryId")] 
		public workWorkEntryId ExitEntryId
		{
			get => GetProperty(ref _exitEntryId);
			set => SetProperty(ref _exitEntryId, value);
		}

		[Ordinal(11)] 
		[RED("exitAnimName")] 
		public CName ExitAnimName
		{
			get => GetProperty(ref _exitAnimName);
			set => SetProperty(ref _exitAnimName, value);
		}

		[Ordinal(12)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		[Ordinal(13)] 
		[RED("isWorkspotInfinite")] 
		public CBool IsWorkspotInfinite
		{
			get => GetProperty(ref _isWorkspotInfinite);
			set => SetProperty(ref _isWorkspotInfinite, value);
		}

		[Ordinal(14)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(15)] 
		[RED("playerParams")] 
		public questUseWorkspotPlayerParams PlayerParams
		{
			get => GetProperty(ref _playerParams);
			set => SetProperty(ref _playerParams, value);
		}

		[Ordinal(16)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetProperty(ref _repeatCommandOnInterrupt);
			set => SetProperty(ref _repeatCommandOnInterrupt, value);
		}

		[Ordinal(17)] 
		[RED("workExcludedGestures")] 
		public CArray<workWorkEntryId> WorkExcludedGestures
		{
			get => GetProperty(ref _workExcludedGestures);
			set => SetProperty(ref _workExcludedGestures, value);
		}

		[Ordinal(18)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(19)] 
		[RED("continueInCombat")] 
		public CBool ContinueInCombat
		{
			get => GetProperty(ref _continueInCombat);
			set => SetProperty(ref _continueInCombat, value);
		}

		[Ordinal(20)] 
		[RED("maxAnimTimeLimit")] 
		public CFloat MaxAnimTimeLimit
		{
			get => GetProperty(ref _maxAnimTimeLimit);
			set => SetProperty(ref _maxAnimTimeLimit, value);
		}

		public questUseWorkspotParamsV1()
		{
			_teleport = true;
			_finishAnimation = true;
			_changeWorkspot = true;
			_isWorkspotInfinite = true;
			_repeatCommandOnInterrupt = true;
		}
	}
}
