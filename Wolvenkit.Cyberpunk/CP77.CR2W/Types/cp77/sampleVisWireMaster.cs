using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleVisWireMaster : gameObject
	{
		[Ordinal(0)]  [RED("dependableEntities")] public CArray<NodeRef> DependableEntities { get; set; }
		[Ordinal(1)]  [RED("found")] public CBool Found { get; set; }
		[Ordinal(2)]  [RED("inFocus")] public CBool InFocus { get; set; }
		[Ordinal(3)]  [RED("lookedAt")] public CBool LookedAt { get; set; }

		public sampleVisWireMaster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
