using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetAchievementProgressRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("achievement")] public CEnum<gamedataAchievement> Achievement { get; set; }
		[Ordinal(2)] [RED("currentValue")] public CInt32 CurrentValue { get; set; }
		[Ordinal(3)] [RED("maxValue")] public CInt32 MaxValue { get; set; }

		public SetAchievementProgressRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
