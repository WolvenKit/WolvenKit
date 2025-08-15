
namespace WolvenKit.RED4.Types
{
	public partial class CameraShotEffect_RotationDamper : vehicleCinematicCameraShotEffect_EulerAnglesDamper
	{
		public CameraShotEffect_RotationDamper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
