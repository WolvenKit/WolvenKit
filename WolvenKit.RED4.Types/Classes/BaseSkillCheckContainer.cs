using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseSkillCheckContainer : IScriptable
	{
		private CHandle<HackingSkillCheck> _hackingCheckSlot;
		private CHandle<EngineeringSkillCheck> _engineeringCheckSlot;
		private CHandle<DemolitionSkillCheck> _demolitionCheckSlot;

		[Ordinal(0)] 
		[RED("hackingCheckSlot")] 
		public CHandle<HackingSkillCheck> HackingCheckSlot
		{
			get => GetProperty(ref _hackingCheckSlot);
			set => SetProperty(ref _hackingCheckSlot, value);
		}

		[Ordinal(1)] 
		[RED("engineeringCheckSlot")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheckSlot
		{
			get => GetProperty(ref _engineeringCheckSlot);
			set => SetProperty(ref _engineeringCheckSlot, value);
		}

		[Ordinal(2)] 
		[RED("demolitionCheckSlot")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheckSlot
		{
			get => GetProperty(ref _demolitionCheckSlot);
			set => SetProperty(ref _demolitionCheckSlot, value);
		}
	}
}
