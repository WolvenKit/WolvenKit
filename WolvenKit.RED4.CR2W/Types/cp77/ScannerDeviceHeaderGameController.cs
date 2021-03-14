using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerDeviceHeaderGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _nameText;
		private inkTextWidgetReference _fluffText;
		private inkRectangleWidgetReference _separator1;
		private inkRectangleWidgetReference _separator2;
		private inkTextWidgetReference _levelText;
		private inkTextWidgetReference _status;
		private inkImageWidgetReference _statusIcon;
		private inkWidgetReference _levelWrapper;
		private CUInt32 _nameCallbackID;
		private CUInt32 _networkLevelCallbackID;
		private CUInt32 _networkStatusCallbackID;
		private CUInt32 _deviceStatusCallbackID;
		private CUInt32 _attitudeCallbackID;
		private CBool _isValidName;
		private CBool _isValidNetworkLevel;
		private CBool _isValidnetworkStatus;
		private CBool _isValidDeviceStatus;

		[Ordinal(5)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get
			{
				if (_nameText == null)
				{
					_nameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nameText", cr2w, this);
				}
				return _nameText;
			}
			set
			{
				if (_nameText == value)
				{
					return;
				}
				_nameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("fluffText")] 
		public inkTextWidgetReference FluffText
		{
			get
			{
				if (_fluffText == null)
				{
					_fluffText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "fluffText", cr2w, this);
				}
				return _fluffText;
			}
			set
			{
				if (_fluffText == value)
				{
					return;
				}
				_fluffText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("separator1")] 
		public inkRectangleWidgetReference Separator1
		{
			get
			{
				if (_separator1 == null)
				{
					_separator1 = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "separator1", cr2w, this);
				}
				return _separator1;
			}
			set
			{
				if (_separator1 == value)
				{
					return;
				}
				_separator1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("separator2")] 
		public inkRectangleWidgetReference Separator2
		{
			get
			{
				if (_separator2 == null)
				{
					_separator2 = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "separator2", cr2w, this);
				}
				return _separator2;
			}
			set
			{
				if (_separator2 == value)
				{
					return;
				}
				_separator2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get
			{
				if (_levelText == null)
				{
					_levelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelText", cr2w, this);
				}
				return _levelText;
			}
			set
			{
				if (_levelText == value)
				{
					return;
				}
				_levelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("status")] 
		public inkTextWidgetReference Status
		{
			get
			{
				if (_status == null)
				{
					_status = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("statusIcon")] 
		public inkImageWidgetReference StatusIcon
		{
			get
			{
				if (_statusIcon == null)
				{
					_statusIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "statusIcon", cr2w, this);
				}
				return _statusIcon;
			}
			set
			{
				if (_statusIcon == value)
				{
					return;
				}
				_statusIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("levelWrapper")] 
		public inkWidgetReference LevelWrapper
		{
			get
			{
				if (_levelWrapper == null)
				{
					_levelWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelWrapper", cr2w, this);
				}
				return _levelWrapper;
			}
			set
			{
				if (_levelWrapper == value)
				{
					return;
				}
				_levelWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("nameCallbackID")] 
		public CUInt32 NameCallbackID
		{
			get
			{
				if (_nameCallbackID == null)
				{
					_nameCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "nameCallbackID", cr2w, this);
				}
				return _nameCallbackID;
			}
			set
			{
				if (_nameCallbackID == value)
				{
					return;
				}
				_nameCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("networkLevelCallbackID")] 
		public CUInt32 NetworkLevelCallbackID
		{
			get
			{
				if (_networkLevelCallbackID == null)
				{
					_networkLevelCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "networkLevelCallbackID", cr2w, this);
				}
				return _networkLevelCallbackID;
			}
			set
			{
				if (_networkLevelCallbackID == value)
				{
					return;
				}
				_networkLevelCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("deviceStatusCallbackID")] 
		public CUInt32 DeviceStatusCallbackID
		{
			get
			{
				if (_deviceStatusCallbackID == null)
				{
					_deviceStatusCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "deviceStatusCallbackID", cr2w, this);
				}
				return _deviceStatusCallbackID;
			}
			set
			{
				if (_deviceStatusCallbackID == value)
				{
					return;
				}
				_deviceStatusCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("attitudeCallbackID")] 
		public CUInt32 AttitudeCallbackID
		{
			get
			{
				if (_attitudeCallbackID == null)
				{
					_attitudeCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "attitudeCallbackID", cr2w, this);
				}
				return _attitudeCallbackID;
			}
			set
			{
				if (_attitudeCallbackID == value)
				{
					return;
				}
				_attitudeCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isValidName")] 
		public CBool IsValidName
		{
			get
			{
				if (_isValidName == null)
				{
					_isValidName = (CBool) CR2WTypeManager.Create("Bool", "isValidName", cr2w, this);
				}
				return _isValidName;
			}
			set
			{
				if (_isValidName == value)
				{
					return;
				}
				_isValidName = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("isValidNetworkLevel")] 
		public CBool IsValidNetworkLevel
		{
			get
			{
				if (_isValidNetworkLevel == null)
				{
					_isValidNetworkLevel = (CBool) CR2WTypeManager.Create("Bool", "isValidNetworkLevel", cr2w, this);
				}
				return _isValidNetworkLevel;
			}
			set
			{
				if (_isValidNetworkLevel == value)
				{
					return;
				}
				_isValidNetworkLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
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

		[Ordinal(21)] 
		[RED("isValidDeviceStatus")] 
		public CBool IsValidDeviceStatus
		{
			get
			{
				if (_isValidDeviceStatus == null)
				{
					_isValidDeviceStatus = (CBool) CR2WTypeManager.Create("Bool", "isValidDeviceStatus", cr2w, this);
				}
				return _isValidDeviceStatus;
			}
			set
			{
				if (_isValidDeviceStatus == value)
				{
					return;
				}
				_isValidDeviceStatus = value;
				PropertySet(this);
			}
		}

		public ScannerDeviceHeaderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
