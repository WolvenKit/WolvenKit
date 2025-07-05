using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workEntryAnim : workIEntry
	{
		[Ordinal(2)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("idleAnim")] 
		public CName IdleAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(5)] 
		[RED("orientationType")] 
		public CEnum<moveMovementOrientationType> OrientationType
		{
			get => GetPropertyValue<CEnum<moveMovementOrientationType>>();
			set => SetPropertyValue<CEnum<moveMovementOrientationType>>(value);
		}

		[Ordinal(6)] 
		[RED("isSynchronized")] 
		public CBool IsSynchronized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("syncOffset")] 
		public Transform SyncOffset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(9)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public workEntryAnim()
		{
			Id = new workWorkEntryId { Id = uint.MaxValue };
			Flags = 65552;
			OrientationType = Enums.moveMovementOrientationType.Forward;
			SyncOffset = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			BlendOutTime = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
