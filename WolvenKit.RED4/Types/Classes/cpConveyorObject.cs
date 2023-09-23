using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpConveyorObject : gameObject
	{
		[Ordinal(36)] 
		[RED("rotationLerpFactor")] 
		public CFloat RotationLerpFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("ignoreZAxis")] 
		public CBool IgnoreZAxis
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public cpConveyorObject()
		{
			RotationLerpFactor = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
