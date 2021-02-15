using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entUncontrolledMovementStartEvent : redEvent
	{
		[Ordinal(0)] [RED("ragdollNoGroundThreshold")] public CFloat RagdollNoGroundThreshold { get; set; }
		[Ordinal(1)] [RED("ragdollOnCollision")] public CBool RagdollOnCollision { get; set; }

		public entUncontrolledMovementStartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
