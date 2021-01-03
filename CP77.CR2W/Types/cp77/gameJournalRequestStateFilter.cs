using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestStateFilter : CVariable
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("failed")] public CBool Failed { get; set; }
		[Ordinal(2)]  [RED("inactive")] public CBool Inactive { get; set; }
		[Ordinal(3)]  [RED("succeeded")] public CBool Succeeded { get; set; }

		public gameJournalRequestStateFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
