using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRewardEvent : redEvent
	{
		[Ordinal(0)]  [RED("rewardName")] public TweakDBID RewardName { get; set; }

		public questRewardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
