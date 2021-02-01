using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChangeRewardSettingsEvent : redEvent
	{
		[Ordinal(0)]  [RED("disableKillReward")] public CBool DisableKillReward { get; set; }
		[Ordinal(1)]  [RED("forceDefeatReward")] public CBool ForceDefeatReward { get; set; }

		public ChangeRewardSettingsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
