using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalContact : gameJournalFileEntry
	{
		[Ordinal(0)]  [RED("name")] public LocalizationString Name { get; set; }
		[Ordinal(1)]  [RED("avatarID")] public TweakDBID AvatarID { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<gameContactType> Type { get; set; }
		[Ordinal(3)]  [RED("useFlatMessageLayout")] public CBool UseFlatMessageLayout { get; set; }

		public gameJournalContact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
