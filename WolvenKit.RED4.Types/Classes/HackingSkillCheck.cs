
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HackingSkillCheck : SkillCheckBase
	{

		public HackingSkillCheck()
		{
			SkillToCheck = Enums.EDeviceChallengeSkill.Hacking;
		}
	}
}
