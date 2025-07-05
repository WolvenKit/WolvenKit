using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WindowControllerPS : DoorControllerPS
	{
		[Ordinal(117)] 
		[RED("windowSkillChecks")] 
		public CHandle<EngDemoContainer> WindowSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		public WindowControllerPS()
		{
			DeviceName = "LocKey#78";
			TweakDBRecord = "Devices.Window";
			TweakDBDescriptionRecord = 113890133552;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
