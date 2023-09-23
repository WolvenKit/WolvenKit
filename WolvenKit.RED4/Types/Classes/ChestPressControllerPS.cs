using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChestPressControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("chestPressSkillChecks")] 
		public CHandle<EngDemoContainer> ChestPressSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(108)] 
		[RED("factOnQHack")] 
		public CName FactOnQHack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(109)] 
		[RED("wasWeighHacked")] 
		public CBool WasWeighHacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ChestPressControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
