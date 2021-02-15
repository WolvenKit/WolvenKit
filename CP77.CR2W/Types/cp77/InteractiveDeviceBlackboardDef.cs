using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] [RED("showAd")] public gamebbScriptID_Bool ShowAd { get; set; }
		[Ordinal(8)] [RED("showVendor")] public gamebbScriptID_Bool ShowVendor { get; set; }

		public InteractiveDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
