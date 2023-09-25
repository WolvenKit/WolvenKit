
namespace WolvenKit.RED4.Types
{
	public partial class DemolitionSkillCheck : SkillCheckBase
	{
		public DemolitionSkillCheck()
		{
			SkillToCheck = Enums.EDeviceChallengeSkill.Athletics;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
