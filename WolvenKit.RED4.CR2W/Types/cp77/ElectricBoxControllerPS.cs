using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElectricBoxControllerPS : MasterControllerPS
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

		public ElectricBoxControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
