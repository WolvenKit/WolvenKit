using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTermDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] [RED("fastTravelPoint")] public gamebbScriptID_Variant FastTravelPoint { get; set; }
		[Ordinal(8)] [RED("triggerWorldMap")] public gamebbScriptID_Bool TriggerWorldMap { get; set; }

		public DataTermDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
