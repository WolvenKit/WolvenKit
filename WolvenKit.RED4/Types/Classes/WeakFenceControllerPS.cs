using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeakFenceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("weakfenceSkillChecks")] 
		public CHandle<EngDemoContainer> WeakfenceSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(105)] 
		[RED("weakFenceSetup")] 
		public WeakFenceSetup WeakFenceSetup
		{
			get => GetPropertyValue<WeakFenceSetup>();
			set => SetPropertyValue<WeakFenceSetup>(value);
		}

		public WeakFenceControllerPS()
		{
			DeviceName = "LocKey#189";
			TweakDBRecord = "Devices.WeakFence";
			TweakDBDescriptionRecord = 128236067982;
			ShouldScannerShowStatus = false;
			ShouldScannerShowNetwork = false;
			ShouldScannerShowRole = true;
			WeakFenceSetup = new WeakFenceSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
