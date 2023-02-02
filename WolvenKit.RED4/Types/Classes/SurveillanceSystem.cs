
namespace WolvenKit.RED4.Types
{
	public partial class SurveillanceSystem : DeviceSystemBase
	{
		public SurveillanceSystem()
		{
			ControllerTypeName = "SurveillanceSystemController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
