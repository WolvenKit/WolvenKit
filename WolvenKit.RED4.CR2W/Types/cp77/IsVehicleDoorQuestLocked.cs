using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsVehicleDoorQuestLocked : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)] [RED("isCheckInverted")] public CBool IsCheckInverted { get; set; }

		public IsVehicleDoorQuestLocked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
