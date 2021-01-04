using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiProgressionViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(0)]  [RED("canBeMerged")] public CBool CanBeMerged { get; set; }
		[Ordinal(1)]  [RED("currentLevel")] public CInt32 CurrentLevel { get; set; }
		[Ordinal(2)]  [RED("delta")] public CInt32 Delta { get; set; }
		[Ordinal(3)]  [RED("expProgress")] public CFloat ExpProgress { get; set; }
		[Ordinal(4)]  [RED("expValue")] public CInt32 ExpValue { get; set; }
		[Ordinal(5)]  [RED("isLevelMaxed")] public CBool IsLevelMaxed { get; set; }
		[Ordinal(6)]  [RED("notificationColorTheme")] public CName NotificationColorTheme { get; set; }
		[Ordinal(7)]  [RED("type")] public CEnum<gamedataProficiencyType> Type { get; set; }

		public gameuiProgressionViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
