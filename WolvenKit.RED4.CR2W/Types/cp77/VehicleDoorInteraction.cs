using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorInteraction : ActionBool
	{
		[Ordinal(25)] [RED("slotID")] public CName SlotID { get; set; }
		[Ordinal(26)] [RED("isInteractionSource")] public CBool IsInteractionSource { get; set; }

		public VehicleDoorInteraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
