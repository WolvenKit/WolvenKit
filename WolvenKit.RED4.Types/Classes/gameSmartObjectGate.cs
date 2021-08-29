using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectGate : RedBaseClass
	{
		private CName _animationName;
		private CEnum<moveMovementType> _movementType;
		private CEnum<moveMovementOrientationType> _movementOrientationType;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(2)] 
		[RED("movementOrientationType")] 
		public CEnum<moveMovementOrientationType> MovementOrientationType
		{
			get => GetProperty(ref _movementOrientationType);
			set => SetProperty(ref _movementOrientationType, value);
		}
	}
}
