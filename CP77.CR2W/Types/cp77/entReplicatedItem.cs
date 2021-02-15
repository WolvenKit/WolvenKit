using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entReplicatedItem : CVariable
	{
		[Ordinal(0)] [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(1)] [RED("netTime")] public netTime NetTime { get; set; }

		public entReplicatedItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
