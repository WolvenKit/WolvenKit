using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entUncontrolledMovementStartEvent : redEvent
	{
		[Ordinal(0)]  [RED("ragdollNoGroundThreshold")] public CFloat RagdollNoGroundThreshold { get; set; }
		[Ordinal(1)]  [RED("ragdollOnCollision")] public CBool RagdollOnCollision { get; set; }

		public entUncontrolledMovementStartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
