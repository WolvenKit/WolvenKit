using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleChangeWindowStateEvent : redEvent
	{
		[Ordinal(0)] [RED("state")] public CEnum<vehicleEQuestVehicleWindowState> State { get; set; }
		[Ordinal(1)] [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }

		public vehicleChangeWindowStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
