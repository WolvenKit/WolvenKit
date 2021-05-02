using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackEngContainer : BaseSkillCheckContainer
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

		public HackEngContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
