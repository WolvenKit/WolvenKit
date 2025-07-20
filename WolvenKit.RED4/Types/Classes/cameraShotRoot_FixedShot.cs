using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cameraShotRoot_FixedShot : vehicleCinematicCameraShotRoot
	{
		[Ordinal(0)] 
		[RED("offsetFromInitialPosition")] 
		public Transform OffsetFromInitialPosition
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public cameraShotRoot_FixedShot()
		{
			OffsetFromInitialPosition = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
