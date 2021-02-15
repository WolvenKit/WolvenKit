using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpBumpEvent : redEvent
	{
		[Ordinal(0)] [RED("amount")] public CUInt32 Amount { get; set; }

		public cpBumpEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
