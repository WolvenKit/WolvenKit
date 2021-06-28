using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifySkillCheckPrereq : gamePlayerScriptableSystemRequest
	{
		private CBool _register;
		private CHandle<SkillCheckPrereqState> _skillCheckState;

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}

		[Ordinal(2)] 
		[RED("skillCheckState")] 
		public CHandle<SkillCheckPrereqState> SkillCheckState
		{
			get => GetProperty(ref _skillCheckState);
			set => SetProperty(ref _skillCheckState, value);
		}

		public ModifySkillCheckPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
