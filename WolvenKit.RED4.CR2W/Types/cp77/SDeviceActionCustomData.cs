using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionCustomData : SDeviceActionData
	{
		private CName _actionID;
		private CBool _on;
		private CBool _off;
		private CBool _unpowered;
		private TweakDBID _displayNameRecord;
		private CString _displayName;
		private CInt32 _customClearance;
		private CBool _isEnabled;
		private CBool _disableOnUse;
		private CName _factToEnableName;
		private CInt32 _quickHackCost;
		private CUInt32 _callbackID;

		[Ordinal(10)] 
		[RED("actionID")] 
		public CName ActionID
		{
			get
			{
				if (_actionID == null)
				{
					_actionID = (CName) CR2WTypeManager.Create("CName", "actionID", cr2w, this);
				}
				return _actionID;
			}
			set
			{
				if (_actionID == value)
				{
					return;
				}
				_actionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("On")] 
		public CBool On
		{
			get
			{
				if (_on == null)
				{
					_on = (CBool) CR2WTypeManager.Create("Bool", "On", cr2w, this);
				}
				return _on;
			}
			set
			{
				if (_on == value)
				{
					return;
				}
				_on = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("Off")] 
		public CBool Off
		{
			get
			{
				if (_off == null)
				{
					_off = (CBool) CR2WTypeManager.Create("Bool", "Off", cr2w, this);
				}
				return _off;
			}
			set
			{
				if (_off == value)
				{
					return;
				}
				_off = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("Unpowered")] 
		public CBool Unpowered
		{
			get
			{
				if (_unpowered == null)
				{
					_unpowered = (CBool) CR2WTypeManager.Create("Bool", "Unpowered", cr2w, this);
				}
				return _unpowered;
			}
			set
			{
				if (_unpowered == value)
				{
					return;
				}
				_unpowered = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("displayNameRecord")] 
		public TweakDBID DisplayNameRecord
		{
			get
			{
				if (_displayNameRecord == null)
				{
					_displayNameRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "displayNameRecord", cr2w, this);
				}
				return _displayNameRecord;
			}
			set
			{
				if (_displayNameRecord == value)
				{
					return;
				}
				_displayNameRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (CString) CR2WTypeManager.Create("String", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("customClearance")] 
		public CInt32 CustomClearance
		{
			get
			{
				if (_customClearance == null)
				{
					_customClearance = (CInt32) CR2WTypeManager.Create("Int32", "customClearance", cr2w, this);
				}
				return _customClearance;
			}
			set
			{
				if (_customClearance == value)
				{
					return;
				}
				_customClearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("disableOnUse")] 
		public CBool DisableOnUse
		{
			get
			{
				if (_disableOnUse == null)
				{
					_disableOnUse = (CBool) CR2WTypeManager.Create("Bool", "disableOnUse", cr2w, this);
				}
				return _disableOnUse;
			}
			set
			{
				if (_disableOnUse == value)
				{
					return;
				}
				_disableOnUse = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("factToEnableName")] 
		public CName FactToEnableName
		{
			get
			{
				if (_factToEnableName == null)
				{
					_factToEnableName = (CName) CR2WTypeManager.Create("CName", "factToEnableName", cr2w, this);
				}
				return _factToEnableName;
			}
			set
			{
				if (_factToEnableName == value)
				{
					return;
				}
				_factToEnableName = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("quickHackCost")] 
		public CInt32 QuickHackCost
		{
			get
			{
				if (_quickHackCost == null)
				{
					_quickHackCost = (CInt32) CR2WTypeManager.Create("Int32", "quickHackCost", cr2w, this);
				}
				return _quickHackCost;
			}
			set
			{
				if (_quickHackCost == value)
				{
					return;
				}
				_quickHackCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get
			{
				if (_callbackID == null)
				{
					_callbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "callbackID", cr2w, this);
				}
				return _callbackID;
			}
			set
			{
				if (_callbackID == value)
				{
					return;
				}
				_callbackID = value;
				PropertySet(this);
			}
		}

		public SDeviceActionCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
