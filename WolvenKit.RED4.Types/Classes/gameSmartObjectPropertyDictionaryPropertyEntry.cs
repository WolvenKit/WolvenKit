using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectPropertyDictionaryPropertyEntry : RedBaseClass
	{
		private CUInt16 _id;
		private CUInt32 _usage;
		private CName _animationName;
		private CUInt64 _sourceAnimset;
		private CEnum<gameSmartObjectPointType> _type;
		private CEnum<moveMovementType> _movementType;
		private CEnum<moveMovementOrientationType> _movementOrientation;
		private CBool _isOnNavmesh;
		private CBool _isReachable;
		private CBool _overObstacle;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public CUInt32 Usage
		{
			get => GetProperty(ref _usage);
			set => SetProperty(ref _usage, value);
		}

		[Ordinal(2)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(3)] 
		[RED("sourceAnimset")] 
		public CUInt64 SourceAnimset
		{
			get => GetProperty(ref _sourceAnimset);
			set => SetProperty(ref _sourceAnimset, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameSmartObjectPointType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(5)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(6)] 
		[RED("movementOrientation")] 
		public CEnum<moveMovementOrientationType> MovementOrientation
		{
			get => GetProperty(ref _movementOrientation);
			set => SetProperty(ref _movementOrientation, value);
		}

		[Ordinal(7)] 
		[RED("isOnNavmesh")] 
		public CBool IsOnNavmesh
		{
			get => GetProperty(ref _isOnNavmesh);
			set => SetProperty(ref _isOnNavmesh, value);
		}

		[Ordinal(8)] 
		[RED("isReachable")] 
		public CBool IsReachable
		{
			get => GetProperty(ref _isReachable);
			set => SetProperty(ref _isReachable, value);
		}

		[Ordinal(9)] 
		[RED("overObstacle")] 
		public CBool OverObstacle
		{
			get => GetProperty(ref _overObstacle);
			set => SetProperty(ref _overObstacle, value);
		}

		public gameSmartObjectPropertyDictionaryPropertyEntry()
		{
			_movementOrientation = new() { Value = Enums.moveMovementOrientationType.Forward };
		}
	}
}
