
namespace WolvenKit.RED4.Types
{
	public partial class LadderControllerPS : ScriptableDeviceComponentPS
	{
		public LadderControllerPS()
		{
			DeviceName = "LocKey#2226";
			TweakDBRecord = 61911487315;
			TweakDBDescriptionRecord = 112612393928;
			ShouldScannerShowStatus = false;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
