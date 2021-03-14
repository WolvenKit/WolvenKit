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
			get
			{
				if (_thumbnailWidgetsData == null)
				{
					_thumbnailWidgetsData = (CArray<SThumbnailWidgetPackage>) CR2WTypeManager.Create("array:SThumbnailWidgetPackage", "thumbnailWidgetsData", cr2w, this);
				}
				return _thumbnailWidgetsData;
			}
			set
			{
				if (_thumbnailWidgetsData == value)
				{
					return;
				}
				_thumbnailWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("onThumbnailWidgetsUpdateListener")] 
		public CUInt32 OnThumbnailWidgetsUpdateListener
		{
			get
			{
				if (_onThumbnailWidgetsUpdateListener == null)
				{
					_onThumbnailWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onThumbnailWidgetsUpdateListener", cr2w, this);
				}
				return _onThumbnailWidgetsUpdateListener;
			}
			set
			{
				if (_onThumbnailWidgetsUpdateListener == value)
				{
					return;
				}
				_onThumbnailWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		public MasterDeviceInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
