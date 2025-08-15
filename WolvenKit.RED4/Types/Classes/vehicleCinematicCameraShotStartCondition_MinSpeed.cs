using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraShotStartCondition_MinSpeed : vehicleCinematicCameraShotStartCondition
	{
		[Ordinal(0)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleCinematicCameraShotStartCondition_MinSpeed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
