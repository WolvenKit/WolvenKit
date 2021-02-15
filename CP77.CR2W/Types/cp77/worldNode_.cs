using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldNode_ : ISerializable
	{
		[Ordinal(0)] [RED("isVisibleInGame")] public CBool IsVisibleInGame { get; set; }
		[Ordinal(1)] [RED("isHostOnly")] public CBool IsHostOnly { get; set; }

		public worldNode_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
