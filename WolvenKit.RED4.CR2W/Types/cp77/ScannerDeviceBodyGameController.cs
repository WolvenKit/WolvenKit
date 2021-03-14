using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerDeviceBodyGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _networkStatusText;
		private inkTextWidgetReference _deviceAuthorizationText;
		private inkCompoundWidgetReference _deviceAuthorizationRow;
		private inkCompoundWidgetReference _networkStatusRow;
		private CUInt32 _networkStatusCallbackID;
		private CUInt32 _deviceAuthorizationCallbackID;
		private CBool _isValidnetworkStatus;
		private CBool _isValidDeviceAuthorization;

		[Ordinal(5)] 
		[RED("networkStatusText")] 
		public inkTextWidgetReference NetworkStatusText
		{
			get
			{
				if (_networkStatusText == null)
				{
					_networkStatusText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "networkStatusText", cr2w, this);
				}
				return _networkStatusText;
			}
			set
			{
				if (_networkStatusText == value)
				{
					return;
				}
				_networkStatusText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("deviceAuthorizationText")] 
		public inkTextWidgetReference DeviceAuthorizationText
		{
			get
			{
				if (_deviceAuthorizationText == null)
				{
					_deviceAuthorizationText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "deviceAuthorizationText", cr2w, this);
				}
				return _deviceAuthorizationText;
			}
			set
			{
				if (_deviceAuthorizationText == value)
				{
					return;
				}
				_deviceAuthorizationText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("deviceAuthorizationRow")] 
		public inkCompoundWidgetReference DeviceAuthorizationRow
		{
			get
			{
				if (_deviceAuthorizationRow == null)
				{
					_deviceAuthorizationRow = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "deviceAuthorizationRow", cr2w, this);
				}
				return _deviceAuthorizationRow;
			}
			set
			{
				if (_deviceAuthorizationRow == value)
				{
					return;
				}
				_deviceAuthorizationRow = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("networkStatusRow")] 
		public inkCompoundWidgetReference NetworkStatusRow
		{
			get
			{
				if (_networkStatusRow == null)
				{
					_networkStatusRow = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "networkStatusRow", cr2w, this);
				}
				return _networkStatusRow;
			}
			set
			{
				if (_networkStatusRow == value)
				{
					return;
				}
				_networkStatusRow = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("networkStatusCallbackID")] 
		public CUInt32 NetworkStatusCallbackID
		{
			get
			{
				if (_networkStatusCallbackID == null)
				{
					_networkStatusCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "networkStatusCallbackID", cr2w, this);
				}
				return _networkStatusCallbackID;
			}
			set
			{
				if (_networkStatusCallbackID == value)
				{
					return;
				}
				_networkStatusCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("deviceAuthorizationCallbackID")] 
		public CUInt32 DeviceAuthorizationCallbackID
		{
			get
			{
				if (_deviceAuthorizationCallbackID == null)
				{
					_deviceAuthorizationCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "deviceAuthorizationCallbackID", cr2w, this);
				}
				return _deviceAuthorizationCallbackID;
			}
			set
			{
				if (_deviceAuthorizationCallbackID == value)
				{
					return;
				}
				_deviceAuthorizationCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isValidnetworkStatus")] 
		public CBool IsValidnetworkStatus
		{
			get
			{
				if (_isValidnetworkStatus == null)
				{
					_isValidnetworkStatus = (CBool) CR2WTypeManager.Create("Bool", "isValidnetworkStatus", cr2w, this);
				}
				return _isValidnetworkStatus;
			}
			set
			{
				if (_isValidnetworkStatus == value)
				{
					return;
				}
				_isValidnetworkStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isValidDeviceAuthorization")] 
		public CBool IsValidDeviceAuthorization
		{
			get
			{
				if (_isValidDeviceAuthorization == null)
				{
					_isValidDeviceAuthorization = (CBool) CR2WTypeManager.Create("Bool", "isValidDeviceAuthorization", cr2w, this);
				}
				return _isValidDeviceAuthorization;
			}
			set
			{
				if (_isValidDeviceAuthorization == value)
				{
					return;
				}
				_isValidDeviceAuthorization = value;
				PropertySet(this);
			}
		}

		public ScannerDeviceBodyGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
