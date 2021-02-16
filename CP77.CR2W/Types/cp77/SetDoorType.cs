using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetDoorType : redEvent
	{
		[Ordinal(0)] [RED("doorTypeSideOne")] public CEnum<EDoorType> DoorTypeSideOne { get; set; }
		[Ordinal(1)] [RED("doorTypeSideTwo")] public CEnum<EDoorType> DoorTypeSideTwo { get; set; }

		public SetDoorType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
