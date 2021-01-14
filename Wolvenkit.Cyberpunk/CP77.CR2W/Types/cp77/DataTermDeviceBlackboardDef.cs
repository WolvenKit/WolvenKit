using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DataTermDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("fastTravelPoint")] public gamebbScriptID_Variant FastTravelPoint { get; set; }
		[Ordinal(1)]  [RED("triggerWorldMap")] public gamebbScriptID_Bool TriggerWorldMap { get; set; }

		public DataTermDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
