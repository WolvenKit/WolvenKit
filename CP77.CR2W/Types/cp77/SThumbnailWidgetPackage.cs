using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SThumbnailWidgetPackage : SWidgetPackage
	{
		[Ordinal(17)] [RED("thumbnailAction")] public CHandle<ThumbnailUI> ThumbnailAction { get; set; }
		[Ordinal(18)] [RED("deviceStatus")] public CString DeviceStatus { get; set; }

		public SThumbnailWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
