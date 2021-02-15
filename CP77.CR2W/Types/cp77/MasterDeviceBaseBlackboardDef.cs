using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MasterDeviceBaseBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] [RED("ThumbnailWidgetsData")] public gamebbScriptID_Variant ThumbnailWidgetsData { get; set; }

		public MasterDeviceBaseBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
