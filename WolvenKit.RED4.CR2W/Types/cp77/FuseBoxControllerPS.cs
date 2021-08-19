using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FuseBoxControllerPS : MasterControllerPS
	{
		private CHandle<EngineeringContainer> _fuseBoxSkillChecks;
		private CBool _isGenerator;
		private CBool _isOverloaded;

		[Ordinal(105)] 
		[RED("fuseBoxSkillChecks")] 
		public CHandle<EngineeringContainer> FuseBoxSkillChecks
		{
			get => GetProperty(ref _fuseBoxSkillChecks);
			set => SetProperty(ref _fuseBoxSkillChecks, value);
		}

		[Ordinal(106)] 
		[RED("isGenerator")] 
		public CBool IsGenerator
		{
			get => GetProperty(ref _isGenerator);
			set => SetProperty(ref _isGenerator, value);
		}

		[Ordinal(107)] 
		[RED("isOverloaded")] 
		public CBool IsOverloaded
		{
			get => GetProperty(ref _isOverloaded);
			set => SetProperty(ref _isOverloaded, value);
		}

		public FuseBoxControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
