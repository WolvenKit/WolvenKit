using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MasterDeviceBaseBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] [RED("ThumbnailWidgetsData")] public gamebbScriptID_Variant ThumbnailWidgetsData { get; set; }

		public MasterDeviceBaseBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
