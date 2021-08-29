using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HackEngContainer : BaseSkillCheckContainer
	{
		private CHandle<HackingSkillCheck> _hackingCheck;
		private CHandle<EngineeringSkillCheck> _engineeringCheck;

		[Ordinal(3)] 
		[RED("hackingCheck")] 
		public CHandle<HackingSkillCheck> HackingCheck
		{
			get => GetProperty(ref _hackingCheck);
			set => SetProperty(ref _hackingCheck, value);
		}

		[Ordinal(4)] 
		[RED("engineeringCheck")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheck
		{
			get => GetProperty(ref _engineeringCheck);
			set => SetProperty(ref _engineeringCheck, value);
		}
	}
}
