using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChestPressControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("chestPressSkillChecks")] 
		public CHandle<EngDemoContainer> ChestPressSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(105)] 
		[RED("factOnQHack")] 
		public CName FactOnQHack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(106)] 
		[RED("wasWeighHacked")] 
		public CBool WasWeighHacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ChestPressControllerPS()
		{
			DeviceName = "LocKey#601";
			TweakDBRecord = 80274358199;
			TweakDBDescriptionRecord = 129856552116;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
