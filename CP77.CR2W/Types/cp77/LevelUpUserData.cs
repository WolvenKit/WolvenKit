using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LevelUpUserData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("data")] public questLevelUpData Data { get; set; }

		public LevelUpUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
