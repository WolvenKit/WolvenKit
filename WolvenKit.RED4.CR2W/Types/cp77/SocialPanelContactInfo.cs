using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactInfo : CVariable
	{
		[Ordinal(0)] [RED("Hash")] public CInt32 Hash { get; set; }
		[Ordinal(1)] [RED("Contact")] public wCHandle<gameJournalContact> Contact { get; set; }

		public SocialPanelContactInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
