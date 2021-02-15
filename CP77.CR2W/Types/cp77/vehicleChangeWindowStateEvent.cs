using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleChangeWindowStateEvent : redEvent
	{
		[Ordinal(0)] [RED("state")] public CEnum<vehicleEQuestVehicleWindowState> State { get; set; }
		[Ordinal(1)] [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }

		public vehicleChangeWindowStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
