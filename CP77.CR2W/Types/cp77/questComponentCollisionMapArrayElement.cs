using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questComponentCollisionMapArrayElement : CVariable
	{
		[Ordinal(0)] [RED("componentNameKey")] public CName ComponentNameKey { get; set; }
		[Ordinal(1)] [RED("enableCollision")] public CBool EnableCollision { get; set; }
		[Ordinal(2)] [RED("enableQueries")] public CBool EnableQueries { get; set; }

		public questComponentCollisionMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
