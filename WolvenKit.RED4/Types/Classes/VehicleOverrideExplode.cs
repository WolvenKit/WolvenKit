using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleOverrideExplode : ActionBool
	{
		[Ordinal(38)] 
		[RED("isRequestedFormOtherDevice")] 
		public CBool IsRequestedFormOtherDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleOverrideExplode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
