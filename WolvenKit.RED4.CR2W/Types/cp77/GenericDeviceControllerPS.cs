using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isRecognizableBySenses;
		private GenericDeviceActionsData _genericDeviceActionsSetup;
		private CHandle<GenericContainer> _genericDeviceSkillChecks;
		private TweakDBID _deviceWidgetRecord;
		private TweakDBID _thumbnailWidgetRecord;
		private CArray<CName> _performedCustomActionsIDs;

		[Ordinal(103)] 
		[RED("isRecognizableBySenses")] 
		public CBool IsRecognizableBySenses
		{
			get
			{
				if (_isRecognizableBySenses == null)
				{
					_isRecognizableBySenses = (CBool) CR2WTypeManager.Create("Bool", "isRecognizableBySenses", cr2w, this);
				}
				return _isRecognizableBySenses;
			}
			set
			{
				if (_isRecognizableBySenses == value)
				{
					return;
				}
				_isRecognizableBySenses = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("genericDeviceActionsSetup")] 
		public GenericDeviceActionsData GenericDeviceActionsSetup
		{
			get
			{
				if (_genericDeviceActionsSetup == null)
				{
					_genericDeviceActionsSetup = (GenericDeviceActionsData) CR2WTypeManager.Create("GenericDeviceActionsData", "genericDeviceActionsSetup", cr2w, this);
				}
				return _genericDeviceActionsSetup;
			}
			set
			{
				if (_genericDeviceActionsSetup == value)
				{
					return;
				}
				_genericDeviceActionsSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("genericDeviceSkillChecks")] 
		public CHandle<GenericContainer> GenericDeviceSkillChecks
		{
			get
			{
				if (_genericDeviceSkillChecks == null)
				{
					_genericDeviceSkillChecks = (CHandle<GenericContainer>) CR2WTypeManager.Create("handle:GenericContainer", "genericDeviceSkillChecks", cr2w, this);
				}
				return _genericDeviceSkillChecks;
			}
			set
			{
				if (_genericDeviceSkillChecks == value)
				{
					return;
				}
				_genericDeviceSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get
			{
				if (_deviceWidgetRecord == null)
				{
					_deviceWidgetRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "deviceWidgetRecord", cr2w, this);
				}
				return _deviceWidgetRecord;
			}
			set
			{
				if (_deviceWidgetRecord == value)
				{
					return;
				}
				_deviceWidgetRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("thumbnailWidgetRecord")] 
		public TweakDBID ThumbnailWidgetRecord
		{
			get
			{
				if (_thumbnailWidgetRecord == null)
				{
					_thumbnailWidgetRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "thumbnailWidgetRecord", cr2w, this);
				}
				return _thumbnailWidgetRecord;
			}
			set
			{
				if (_thumbnailWidgetRecord == value)
				{
					return;
				}
				_thumbnailWidgetRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("performedCustomActionsIDs")] 
		public CArray<CName> PerformedCustomActionsIDs
		{
			get
			{
				if (_performedCustomActionsIDs == null)
				{
					_performedCustomActionsIDs = (CArray<CName>) CR2WTypeManager.Create("array:CName", "performedCustomActionsIDs", cr2w, this);
				}
				return _performedCustomActionsIDs;
			}
			set
			{
				if (_performedCustomActionsIDs == value)
				{
					return;
				}
				_performedCustomActionsIDs = value;
				PropertySet(this);
			}
		}

		public GenericDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
