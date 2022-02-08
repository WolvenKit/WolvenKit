using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpConveyorObject : gameObject
	{
		[Ordinal(40)] 
		[RED("rotationLerpFactor")] 
		public CFloat RotationLerpFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("ignoreZAxis")] 
		public CBool IgnoreZAxis
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public cpConveyorObject()
		{
			RotationLerpFactor = 0.100000F;
		}
	}
}
