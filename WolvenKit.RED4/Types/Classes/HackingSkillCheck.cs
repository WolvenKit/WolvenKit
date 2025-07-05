
namespace WolvenKit.RED4.Types
{
	public partial class HackingSkillCheck : SkillCheckBase
	{
		public HackingSkillCheck()
		{
			SkillToCheck = Enums.EDeviceChallengeSkill.Hacking;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
