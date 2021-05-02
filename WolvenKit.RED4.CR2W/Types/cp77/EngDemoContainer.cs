using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EngDemoContainer : BaseSkillCheckContainer
	{
		private CHandle<EngineeringSkillCheck> _engineeringCheck;
		private CHandle<DemolitionSkillCheck> _demolitionCheck;

		[Ordinal(3)] 
		[RED("engineeringCheck")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheck
		{
			get => GetProperty(ref _engineeringCheck);
			set => SetProperty(ref _engineeringCheck, value);
		}

		[Ordinal(4)] 
		[RED("demolitionCheck")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheck
		{
			get => GetProperty(ref _demolitionCheck);
			set => SetProperty(ref _demolitionCheck, value);
		}

		public EngDemoContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
