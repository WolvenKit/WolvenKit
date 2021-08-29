using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifySkillCheckPrereq : gamePlayerScriptableSystemRequest
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
	}
}
