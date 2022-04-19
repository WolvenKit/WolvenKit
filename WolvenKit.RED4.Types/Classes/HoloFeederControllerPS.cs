
namespace WolvenKit.RED4.Types
{
	public partial class HoloFeederControllerPS : ScriptableDeviceComponentPS
	{
		public HoloFeederControllerPS()
		{
			DeviceName = "LocKey#95";
			TweakDBRecord = 77660230936;
			TweakDBDescriptionRecord = 131405305371;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
