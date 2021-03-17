using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MasterDeviceInkGameControllerBase : DeviceInkGameControllerBase
	{
		private CArray<SThumbnailWidgetPackage> _thumbnailWidgetsData;
		private CUInt32 _onThumbnailWidgetsUpdateListener;

		[Ordinal(16)] 
		[RED("thumbnailWidgetsData")] 
		public CArray<SThumbnailWidgetPackage> ThumbnailWidgetsData
		{
			get => GetProperty(ref _thumbnailWidgetsData);
			set => SetProperty(ref _thumbnailWidgetsData, value);
		}

		[Ordinal(17)] 
		[RED("onThumbnailWidgetsUpdateListener")] 
		public CUInt32 OnThumbnailWidgetsUpdateListener
		{
			get => GetProperty(ref _onThumbnailWidgetsUpdateListener);
			set => SetProperty(ref _onThumbnailWidgetsUpdateListener, value);
		}

		public MasterDeviceInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
