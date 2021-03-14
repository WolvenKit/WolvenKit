using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questGOGReward_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] [RED("rewardRecordId")] public TweakDBID RewardRecordId { get; set; }

		public questGOGReward_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
