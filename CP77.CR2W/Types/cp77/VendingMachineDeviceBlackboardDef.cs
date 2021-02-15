using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendingMachineDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] [RED("ActionStatus")] public gamebbScriptID_Variant ActionStatus { get; set; }
		[Ordinal(8)] [RED("SoldOut")] public gamebbScriptID_Bool SoldOut { get; set; }

		public VendingMachineDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
