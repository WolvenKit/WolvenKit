using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BackDoorDeviceBlackboardDef : MasterDeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("bootModule")] public gamebbScriptID_Int32 BootModule { get; set; }
		[Ordinal(1)]  [RED("isInDefaultState")] public gamebbScriptID_Bool IsInDefaultState { get; set; }
		[Ordinal(2)]  [RED("shutdownModule")] public gamebbScriptID_Int32 ShutdownModule { get; set; }

		public BackDoorDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
