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
			OffsetFromInitialPosition = new Transform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
