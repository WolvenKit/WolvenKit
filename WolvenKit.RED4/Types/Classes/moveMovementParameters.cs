using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class moveMovementParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<moveMovementType> Type
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(1)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("deceleration")] 
		public CFloat Deceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public moveMovementParameters()
		{
			MaxSpeed = 4.500000F;
			Acceleration = 16.000000F;
			Deceleration = 16.000000F;
			RotationSpeed = 180.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
