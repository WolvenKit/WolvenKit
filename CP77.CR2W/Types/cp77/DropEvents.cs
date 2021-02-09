using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropEvents : CarriedObjectEvents
	{
		[Ordinal(9)]  [RED("ragdollReenabled")] public CBool RagdollReenabled { get; set; }

		public DropEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
