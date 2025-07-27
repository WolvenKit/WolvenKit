using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraShotStartCondition_MaxSpeed : vehicleCinematicCameraShotStartCondition
	{
		[Ordinal(0)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleCinematicCameraShotStartCondition_MaxSpeed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
