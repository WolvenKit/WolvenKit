using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InterestingFactsListenersIds : CVariable
	{
		[Ordinal(0)] [RED("zone")] public CUInt32 Zone { get; set; }

		public InterestingFactsListenersIds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
