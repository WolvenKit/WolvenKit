using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseSkillCheckContainer : IScriptable
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

		public BaseSkillCheckContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
