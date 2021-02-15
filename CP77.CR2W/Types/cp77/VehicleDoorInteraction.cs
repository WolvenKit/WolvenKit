using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorInteraction : ActionBool
	{
		[Ordinal(25)] [RED("slotID")] public CName SlotID { get; set; }
		[Ordinal(26)] [RED("isInteractionSource")] public CBool IsInteractionSource { get; set; }

		public VehicleDoorInteraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
