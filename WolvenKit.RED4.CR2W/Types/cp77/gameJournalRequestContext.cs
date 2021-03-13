using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestContext : CVariable
	{
		[Ordinal(0)] [RED("stateFilter")] public gameJournalRequestStateFilter StateFilter { get; set; }
		[Ordinal(1)] [RED("classFilter")] public gameJournalRequestClassFilter ClassFilter { get; set; }

		public gameJournalRequestContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
