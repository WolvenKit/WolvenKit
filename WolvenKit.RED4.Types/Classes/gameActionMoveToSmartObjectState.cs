using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionMoveToSmartObjectState : gameActionMoveToState
	{
		private CUInt64 _targetHash;
		private CBool _usePathfinding;
		private CBool _useStart;
		private CBool _useStop;
		private CEnum<gameSmartObjectInstanceEntryType> _entryType;
		private CEnum<moveMovementType> _movementType;
		private CWeakHandle<gameObject> _strafingTarget;
		private Vector3 _entryDirection;
		private Vector3 _entryPointPos;
		private Vector4 _entryPointDir;
		private CName _animationName;
		private CBool _isInSmartObject;

		[Ordinal(9)] 
		[RED("targetHash")] 
		public CUInt64 TargetHash
		{
			get => GetProperty(ref _targetHash);
			set => SetProperty(ref _targetHash, value);
		}

		[Ordinal(10)] 
		[RED("usePathfinding")] 
		public CBool UsePathfinding
		{
			get => GetProperty(ref _usePathfinding);
			set => SetProperty(ref _usePathfinding, value);
		}

		[Ordinal(11)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(12)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(13)] 
		[RED("entryType")] 
		public CEnum<gameSmartObjectInstanceEntryType> EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}

		[Ordinal(14)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(15)] 
		[RED("strafingTarget")] 
		public CWeakHandle<gameObject> StrafingTarget
		{
			get => GetProperty(ref _strafingTarget);
			set => SetProperty(ref _strafingTarget, value);
		}

		[Ordinal(16)] 
		[RED("entryDirection")] 
		public Vector3 EntryDirection
		{
			get => GetProperty(ref _entryDirection);
			set => SetProperty(ref _entryDirection, value);
		}

		[Ordinal(17)] 
		[RED("entryPointPos")] 
		public Vector3 EntryPointPos
		{
			get => GetProperty(ref _entryPointPos);
			set => SetProperty(ref _entryPointPos, value);
		}

		[Ordinal(18)] 
		[RED("entryPointDir")] 
		public Vector4 EntryPointDir
		{
			get => GetProperty(ref _entryPointDir);
			set => SetProperty(ref _entryPointDir, value);
		}

		[Ordinal(19)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(20)] 
		[RED("isInSmartObject")] 
		public CBool IsInSmartObject
		{
			get => GetProperty(ref _isInSmartObject);
			set => SetProperty(ref _isInSmartObject, value);
		}
	}
}
