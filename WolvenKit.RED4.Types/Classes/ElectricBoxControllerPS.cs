using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElectricBoxControllerPS : MasterControllerPS
	{
		private CHandle<EngineeringContainer> _techieSkillChecks;
		private ComputerQuickHackData _questFactSetup;
		private CBool _isOverriden;

		[Ordinal(105)] 
		[RED("techieSkillChecks")] 
		public CHandle<EngineeringContainer> TechieSkillChecks
		{
			get => GetProperty(ref _techieSkillChecks);
			set => SetProperty(ref _techieSkillChecks, value);
		}

		[Ordinal(106)] 
		[RED("questFactSetup")] 
		public ComputerQuickHackData QuestFactSetup
		{
			get => GetProperty(ref _questFactSetup);
			set => SetProperty(ref _questFactSetup, value);
		}

		[Ordinal(107)] 
		[RED("isOverriden")] 
		public CBool IsOverriden
		{
			get => GetProperty(ref _isOverriden);
			set => SetProperty(ref _isOverriden, value);
		}
	}
}
