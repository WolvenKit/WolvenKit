using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleMultipliers : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("throttleInputMultiplier")] 
		public CFloat ThrottleInputMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("rpmMultiplier")] 
		public CFloat RpmMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioVehicleMultipliers()
		{
			ThrottleInputMultiplier = 1.000000F;
			RpmMultiplier = 1.000000F;
		}
	}
}
