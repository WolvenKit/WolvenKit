using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ElevatorDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] [RED("CurrentFloor")] public gamebbScriptID_String CurrentFloor { get; set; }
		[Ordinal(8)] [RED("isPlayerScanned")] public gamebbScriptID_Bool IsPlayerScanned { get; set; }
		[Ordinal(9)] [RED("isPaused")] public gamebbScriptID_Bool IsPaused { get; set; }

		public ElevatorDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
