using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElectricBoxControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("techieSkillChecks")] 
		public CHandle<EngineeringContainer> TechieSkillChecks
		{
			get => GetPropertyValue<CHandle<EngineeringContainer>>();
			set => SetPropertyValue<CHandle<EngineeringContainer>>(value);
		}

		[Ordinal(109)] 
		[RED("questFactSetup")] 
		public ComputerQuickHackData QuestFactSetup
		{
			get => GetPropertyValue<ComputerQuickHackData>();
			set => SetPropertyValue<ComputerQuickHackData>(value);
		}

		[Ordinal(110)] 
		[RED("isOverriden")] 
		public CBool IsOverriden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ElectricBoxControllerPS()
		{
			QuestFactSetup = new ComputerQuickHackData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
