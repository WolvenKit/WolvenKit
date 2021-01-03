using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractiveDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("showAd")] public gamebbScriptID_Bool ShowAd { get; set; }
		[Ordinal(1)]  [RED("showVendor")] public gamebbScriptID_Bool ShowVendor { get; set; }

		public InteractiveDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
