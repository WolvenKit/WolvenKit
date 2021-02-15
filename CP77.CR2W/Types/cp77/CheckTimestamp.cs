using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckTimestamp : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("validationTime")] public CFloat ValidationTime { get; set; }
		[Ordinal(1)] [RED("timestampArgument")] public CName TimestampArgument { get; set; }

		public CheckTimestamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
