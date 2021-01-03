using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MasterDeviceInkGameControllerBase : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("onThumbnailWidgetsUpdateListener")] public CUInt32 OnThumbnailWidgetsUpdateListener { get; set; }
		[Ordinal(1)]  [RED("thumbnailWidgetsData")] public CArray<SThumbnailWidgetPackage> ThumbnailWidgetsData { get; set; }

		public MasterDeviceInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
