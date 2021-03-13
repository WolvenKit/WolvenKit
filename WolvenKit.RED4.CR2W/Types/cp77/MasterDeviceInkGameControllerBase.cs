using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MasterDeviceInkGameControllerBase : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("thumbnailWidgetsData")] public CArray<SThumbnailWidgetPackage> ThumbnailWidgetsData { get; set; }
		[Ordinal(17)] [RED("onThumbnailWidgetsUpdateListener")] public CUInt32 OnThumbnailWidgetsUpdateListener { get; set; }

		public MasterDeviceInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
