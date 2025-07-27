using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cameraShotRoot_FixedOnVehicleNonSuspensionTracking : cameraShotRoot_FixedOnVehicle
	{
		[Ordinal(6)] 
		[RED("offsetFromCar")] 
		public Transform OffsetFromCar
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public cameraShotRoot_FixedOnVehicleNonSuspensionTracking()
		{
			OffsetFromCar = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
