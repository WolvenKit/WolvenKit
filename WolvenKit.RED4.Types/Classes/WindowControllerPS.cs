using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WindowControllerPS : DoorControllerPS
	{
		[Ordinal(114)] 
		[RED("windowSkillChecks")] 
		public CHandle<EngDemoContainer> WindowSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		public WindowControllerPS()
		{
			DeviceName = "LocKey#78";
			TweakDBRecord = new() { Value = 63727146667 };
			TweakDBDescriptionRecord = new() { Value = 113890133552 };
		}
	}
}
