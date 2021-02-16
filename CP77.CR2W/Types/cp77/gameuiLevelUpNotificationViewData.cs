using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiLevelUpNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("canBeMerged")] public CBool CanBeMerged { get; set; }
		[Ordinal(6)] [RED("levelupdata")] public questLevelUpData Levelupdata { get; set; }
		[Ordinal(7)] [RED("proficiencyRecord")] public CHandle<gamedataProficiency_Record> ProficiencyRecord { get; set; }
		[Ordinal(8)] [RED("profString")] public CString ProfString { get; set; }

		public gameuiLevelUpNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
