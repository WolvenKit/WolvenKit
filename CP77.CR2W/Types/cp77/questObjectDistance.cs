using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questObjectDistance : questIDistance
	{
		[Ordinal(0)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(1)] [RED("nodeRef1")] public gameEntityReference NodeRef1 { get; set; }
		[Ordinal(2)] [RED("nodeRef2")] public gameEntityReference NodeRef2 { get; set; }

		public questObjectDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
