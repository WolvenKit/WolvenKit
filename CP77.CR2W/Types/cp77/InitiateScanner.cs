using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InitiateScanner : redEvent
	{
		[Ordinal(0)] [RED("trespasserEntryIndex")] public CInt32 TrespasserEntryIndex { get; set; }

		public InitiateScanner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
