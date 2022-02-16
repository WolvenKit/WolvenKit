using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleVehicleTrafficBumpEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("impactVelocityChange")] 
		public CFloat ImpactVelocityChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
