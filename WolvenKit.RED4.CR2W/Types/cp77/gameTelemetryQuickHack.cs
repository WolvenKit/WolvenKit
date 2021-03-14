using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryQuickHack : CVariable
	{
		private CName _actionName;
		private CString _titleLocKey;
		private CString _targetType;
		private TweakDBID _quickHackRecordID;
		private CInt32 _quality;

		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (CName) CR2WTypeManager.Create("CName", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("titleLocKey")] 
		public CString TitleLocKey
		{
			get
			{
				if (_titleLocKey == null)
				{
					_titleLocKey = (CString) CR2WTypeManager.Create("String", "titleLocKey", cr2w, this);
				}
				return _titleLocKey;
			}
			set
			{
				if (_titleLocKey == value)
				{
					return;
				}
				_titleLocKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetType")] 
		public CString TargetType
		{
			get
			{
				if (_targetType == null)
				{
					_targetType = (CString) CR2WTypeManager.Create("String", "targetType", cr2w, this);
				}
				return _targetType;
			}
			set
			{
				if (_targetType == value)
				{
					return;
				}
				_targetType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("quickHackRecordID")] 
		public TweakDBID QuickHackRecordID
		{
			get
			{
				if (_quickHackRecordID == null)
				{
					_quickHackRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "quickHackRecordID", cr2w, this);
				}
				return _quickHackRecordID;
			}
			set
			{
				if (_quickHackRecordID == value)
				{
					return;
				}
				_quickHackRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get
			{
				if (_quality == null)
				{
					_quality = (CInt32) CR2WTypeManager.Create("Int32", "quality", cr2w, this);
				}
				return _quality;
			}
			set
			{
				if (_quality == value)
				{
					return;
				}
				_quality = value;
				PropertySet(this);
			}
		}

		public gameTelemetryQuickHack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
