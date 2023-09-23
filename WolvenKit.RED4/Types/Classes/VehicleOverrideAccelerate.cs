using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleOverrideAccelerate : ActionBool
	{
		[Ordinal(38)] 
		[RED("isRequestedFormOtherDevice")] 
		public CBool IsRequestedFormOtherDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleOverrideAccelerate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
