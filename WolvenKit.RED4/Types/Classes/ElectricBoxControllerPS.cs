using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElectricBoxControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("techieSkillChecks")] 
		public CHandle<EngineeringContainer> TechieSkillChecks
		{
			get => GetPropertyValue<CHandle<EngineeringContainer>>();
			set => SetPropertyValue<CHandle<EngineeringContainer>>(value);
		}

		[Ordinal(106)] 
		[RED("questFactSetup")] 
		public ComputerQuickHackData QuestFactSetup
		{
			get => GetPropertyValue<ComputerQuickHackData>();
			set => SetPropertyValue<ComputerQuickHackData>(value);
		}

		[Ordinal(107)] 
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
