using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionMoveToSmartObjectState : gameActionMoveToState
	{
		[Ordinal(9)] 
		[RED("targetHash")] 
		public CUInt64 TargetHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(10)] 
		[RED("usePathfinding")] 
		public CBool UsePathfinding
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("entryType")] 
		public CEnum<gameSmartObjectInstanceEntryType> EntryType
		{
			get => GetPropertyValue<CEnum<gameSmartObjectInstanceEntryType>>();
			set => SetPropertyValue<CEnum<gameSmartObjectInstanceEntryType>>(value);
		}

		[Ordinal(14)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(15)] 
		[RED("strafingTarget")] 
		public CWeakHandle<gameObject> StrafingTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(16)] 
		[RED("entryDirection")] 
		public Vector3 EntryDirection
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(17)] 
		[RED("entryPointPos")] 
		public Vector3 EntryPointPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(18)] 
		[RED("entryPointDir")] 
		public Vector4 EntryPointDir
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(19)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("isInSmartObject")] 
		public CBool IsInSmartObject
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameActionMoveToSmartObjectState()
		{
			UsePathfinding = true;
			UseStart = true;
			UseStop = true;
			EntryDirection = new Vector3 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };
			EntryPointPos = new Vector3();
			EntryPointDir = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
