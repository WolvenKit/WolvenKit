using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animIDyngConstraint : ISerializable
	{
        [Ordinal(999)] [RED("isDebugEnabled")] public CBool isDebugEnabled { get; set; }

		public animIDyngConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
