using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSmartObjectPropertyDictionaryPropertyEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public CUInt32 Usage
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("sourceAnimset")] 
		public CUInt64 SourceAnimset
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameSmartObjectPointType> Type
		{
			get => GetPropertyValue<CEnum<gameSmartObjectPointType>>();
			set => SetPropertyValue<CEnum<gameSmartObjectPointType>>(value);
		}

		[Ordinal(5)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(6)] 
		[RED("movementOrientation")] 
		public CEnum<moveMovementOrientationType> MovementOrientation
		{
			get => GetPropertyValue<CEnum<moveMovementOrientationType>>();
			set => SetPropertyValue<CEnum<moveMovementOrientationType>>(value);
		}

		[Ordinal(7)] 
		[RED("isOnNavmesh")] 
		public CBool IsOnNavmesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("isReachable")] 
		public CBool IsReachable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("overObstacle")] 
		public CBool OverObstacle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSmartObjectPropertyDictionaryPropertyEntry()
		{
			MovementOrientation = Enums.moveMovementOrientationType.Forward;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
