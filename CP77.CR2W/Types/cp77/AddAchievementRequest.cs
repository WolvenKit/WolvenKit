using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AddAchievementRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("achievement")] public CEnum<gamedataAchievement> Achievement { get; set; }
		[Ordinal(1)]  [RED("achievementRecord")] public wCHandle<gamedataAchievement_Record> AchievementRecord { get; set; }

		public AddAchievementRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
