
namespace WolvenKit.RED4.Types
{
	public partial class DestructibleMasterLightControllerPS : DestructibleMasterDeviceControllerPS
	{
		public DestructibleMasterLightControllerPS()
		{
			DeviceName = "LocKey#42165";
			TweakDBRecord = 90241852909;
			TweakDBDescriptionRecord = 142476847136;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
