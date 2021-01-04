using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitReactionCumulativeDamageUpdate : redEvent
	{
		[Ordinal(0)]  [RED("prevUpdateTime")] public CFloat PrevUpdateTime { get; set; }

		public HitReactionCumulativeDamageUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
