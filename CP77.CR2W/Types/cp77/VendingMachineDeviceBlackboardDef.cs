using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendingMachineDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("ActionStatus")] public gamebbScriptID_Variant ActionStatus { get; set; }
		[Ordinal(1)]  [RED("SoldOut")] public gamebbScriptID_Bool SoldOut { get; set; }

		public VendingMachineDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
