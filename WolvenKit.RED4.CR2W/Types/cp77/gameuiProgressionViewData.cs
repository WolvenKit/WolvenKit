using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiProgressionViewData : gameuiGenericNotificationViewData
	{
		private CInt32 _expValue;
		private CFloat _expProgress;
		private CInt32 _delta;
		private CName _notificationColorTheme;
		private CBool _canBeMerged;
		private CInt32 _currentLevel;
		private CBool _isLevelMaxed;
		private CEnum<gamedataProficiencyType> _type;

		[Ordinal(5)] 
		[RED("expValue")] 
		public CInt32 ExpValue
		{
			get
			{
				if (_expValue == null)
				{
					_expValue = (CInt32) CR2WTypeManager.Create("Int32", "expValue", cr2w, this);
				}
				return _expValue;
			}
			set
			{
				if (_expValue == value)
				{
					return;
				}
				_expValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("expProgress")] 
		public CFloat ExpProgress
		{
			get
			{
				if (_expProgress == null)
				{
					_expProgress = (CFloat) CR2WTypeManager.Create("Float", "expProgress", cr2w, this);
				}
				return _expProgress;
			}
			set
			{
				if (_expProgress == value)
				{
					return;
				}
				_expProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("delta")] 
		public CInt32 Delta
		{
			get
			{
				if (_delta == null)
				{
					_delta = (CInt32) CR2WTypeManager.Create("Int32", "delta", cr2w, this);
				}
				return _delta;
			}
			set
			{
				if (_delta == value)
				{
					return;
				}
				_delta = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("notificationColorTheme")] 
		public CName NotificationColorTheme
		{
			get
			{
				if (_notificationColorTheme == null)
				{
					_notificationColorTheme = (CName) CR2WTypeManager.Create("CName", "notificationColorTheme", cr2w, this);
				}
				return _notificationColorTheme;
			}
			set
			{
				if (_notificationColorTheme == value)
				{
					return;
				}
				_notificationColorTheme = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get
			{
				if (_canBeMerged == null)
				{
					_canBeMerged = (CBool) CR2WTypeManager.Create("Bool", "canBeMerged", cr2w, this);
				}
				return _canBeMerged;
			}
			set
			{
				if (_canBeMerged == value)
				{
					return;
				}
				_canBeMerged = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get
			{
				if (_currentLevel == null)
				{
					_currentLevel = (CInt32) CR2WTypeManager.Create("Int32", "currentLevel", cr2w, this);
				}
				return _currentLevel;
			}
			set
			{
				if (_currentLevel == value)
				{
					return;
				}
				_currentLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isLevelMaxed")] 
		public CBool IsLevelMaxed
		{
			get
			{
				if (_isLevelMaxed == null)
				{
					_isLevelMaxed = (CBool) CR2WTypeManager.Create("Bool", "isLevelMaxed", cr2w, this);
				}
				return _isLevelMaxed;
			}
			set
			{
				if (_isLevelMaxed == value)
				{
					return;
				}
				_isLevelMaxed = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public gameuiProgressionViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
