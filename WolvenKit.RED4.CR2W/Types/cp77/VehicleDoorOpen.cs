using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorOpen : ActionBool
	{
		[Ordinal(25)] [RED("slotID")] public CName SlotID { get; set; }
		[Ordinal(26)] [RED("shouldAutoClose")] public CBool ShouldAutoClose { get; set; }
		[Ordinal(27)] [RED("autoCloseTime")] public CFloat AutoCloseTime { get; set; }

		public VehicleDoorOpen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
