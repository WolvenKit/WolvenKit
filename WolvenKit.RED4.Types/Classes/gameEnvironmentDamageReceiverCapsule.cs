using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEnvironmentDamageReceiverCapsule : gameEnvironmentDamageReceiverShape
	{
		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameEnvironmentDamageReceiverCapsule()
		{
			Transform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			Radius = 1.000000F;
			Height = 1.000000F;
		}
	}
}
