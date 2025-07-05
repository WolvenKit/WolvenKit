
namespace WolvenKit.RED4.Types
{
	public partial class EngineeringSkillCheck : SkillCheckBase
	{
		public EngineeringSkillCheck()
		{
			SkillToCheck = Enums.EDeviceChallengeSkill.Engineering;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
