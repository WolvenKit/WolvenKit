using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetBodyPositionEvent : redEvent
	{
		[Ordinal(0)] [RED("bodyPosition")] public Vector4 BodyPosition { get; set; }
		[Ordinal(1)] [RED("bodyPositionID")] public entEntityID BodyPositionID { get; set; }
		[Ordinal(2)] [RED("pickedUp")] public CBool PickedUp { get; set; }

		public SetBodyPositionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
