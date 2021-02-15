using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactInfo : CVariable
	{
		[Ordinal(0)] [RED("Hash")] public CInt32 Hash { get; set; }
		[Ordinal(1)] [RED("Contact")] public wCHandle<gameJournalContact> Contact { get; set; }

		public SocialPanelContactInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
