using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SThumbnailWidgetPackage : SWidgetPackage
	{
		private CHandle<ThumbnailUI> _thumbnailAction;
		private CString _deviceStatus;

		[Ordinal(17)] 
		[RED("thumbnailAction")] 
		public CHandle<ThumbnailUI> ThumbnailAction
		{
			get
			{
				if (_thumbnailAction == null)
				{
					_thumbnailAction = (CHandle<ThumbnailUI>) CR2WTypeManager.Create("handle:ThumbnailUI", "thumbnailAction", cr2w, this);
				}
				return _thumbnailAction;
			}
			set
			{
				if (_thumbnailAction == value)
				{
					return;
				}
				_thumbnailAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get
			{
				if (_deviceStatus == null)
				{
					_deviceStatus = (CString) CR2WTypeManager.Create("String", "deviceStatus", cr2w, this);
				}
				return _deviceStatus;
			}
			set
			{
				if (_deviceStatus == value)
				{
					return;
				}
				_deviceStatus = value;
				PropertySet(this);
			}
		}

		public SThumbnailWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
