using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifySkillCheckPrereq : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("skillCheckState")] 
		public CHandle<SkillCheckPrereqState> SkillCheckState
		{
			get => GetPropertyValue<CHandle<SkillCheckPrereqState>>();
			set => SetPropertyValue<CHandle<SkillCheckPrereqState>>(value);
		}
	}
}
