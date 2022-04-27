using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSmartObjectGate : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(2)] 
		[RED("movementOrientationType")] 
		public CEnum<moveMovementOrientationType> MovementOrientationType
		{
			get => GetPropertyValue<CEnum<moveMovementOrientationType>>();
			set => SetPropertyValue<CEnum<moveMovementOrientationType>>(value);
		}

		public gameSmartObjectGate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
