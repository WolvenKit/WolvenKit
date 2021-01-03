using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestContext : CVariable
	{
		[Ordinal(0)]  [RED("classFilter")] public gameJournalRequestClassFilter ClassFilter { get; set; }
		[Ordinal(1)]  [RED("stateFilter")] public gameJournalRequestStateFilter StateFilter { get; set; }

		public gameJournalRequestContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
