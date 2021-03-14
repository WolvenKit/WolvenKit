using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhackData : IScriptable
	{
		private CHandle<BaseScriptableAction> _action;
		private entEntityID _actionOwner;
		private CName _actionOwnerName;
		private TweakDBID _icon;
		private CName _iconCategory;
		private CString _title;
		private CString _titleAlternative;
		private CString _description;
		private CString _inactiveReason;
		private CBool _isLocked;
		private CEnum<EActionInactivityReson> _actionState;
		private CEnum<gamedataObjectActionType> _type;
		private CInt32 _cost;
		private CInt32 _costRaw;
		private CFloat _uploadTime;
		private CFloat _duration;
		private CBool _iCELevelVisible;
		private CFloat _iCELevel;
		private CArray<TweakDBID> _vulnerabilities;
		private CInt32 _quality;
		private CBool _isInstant;
		private CFloat _cooldown;
		private TweakDBID _cooldownTweak;
		private CBool _actionMatchesTarget;
		private CInt32 _maxListSize;
		private wCHandle<gamedataHackCategory_Record> _category;
		private CArray<wCHandle<gamedataObjectActionEffect_Record>> _actionCompletionEffects;
		private CBool _networkBreached;

		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<BaseScriptableAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<BaseScriptableAction>) CR2WTypeManager.Create("handle:BaseScriptableAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionOwner")] 
		public entEntityID ActionOwner
		{
			get
			{
				if (_actionOwner == null)
				{
					_actionOwner = (entEntityID) CR2WTypeManager.Create("entEntityID", "actionOwner", cr2w, this);
				}
				return _actionOwner;
			}
			set
			{
				if (_actionOwner == value)
				{
					return;
				}
				_actionOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("actionOwnerName")] 
		public CName ActionOwnerName
		{
			get
			{
				if (_actionOwnerName == null)
				{
					_actionOwnerName = (CName) CR2WTypeManager.Create("CName", "actionOwnerName", cr2w, this);
				}
				return _actionOwnerName;
			}
			set
			{
				if (_actionOwnerName == value)
				{
					return;
				}
				_actionOwnerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public TweakDBID Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("iconCategory")] 
		public CName IconCategory
		{
			get
			{
				if (_iconCategory == null)
				{
					_iconCategory = (CName) CR2WTypeManager.Create("CName", "iconCategory", cr2w, this);
				}
				return _iconCategory;
			}
			set
			{
				if (_iconCategory == value)
				{
					return;
				}
				_iconCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("titleAlternative")] 
		public CString TitleAlternative
		{
			get
			{
				if (_titleAlternative == null)
				{
					_titleAlternative = (CString) CR2WTypeManager.Create("String", "titleAlternative", cr2w, this);
				}
				return _titleAlternative;
			}
			set
			{
				if (_titleAlternative == value)
				{
					return;
				}
				_titleAlternative = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inactiveReason")] 
		public CString InactiveReason
		{
			get
			{
				if (_inactiveReason == null)
				{
					_inactiveReason = (CString) CR2WTypeManager.Create("String", "inactiveReason", cr2w, this);
				}
				return _inactiveReason;
			}
			set
			{
				if (_inactiveReason == value)
				{
					return;
				}
				_inactiveReason = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("actionState")] 
		public CEnum<EActionInactivityReson> ActionState
		{
			get
			{
				if (_actionState == null)
				{
					_actionState = (CEnum<EActionInactivityReson>) CR2WTypeManager.Create("EActionInactivityReson", "actionState", cr2w, this);
				}
				return _actionState;
			}
			set
			{
				if (_actionState == value)
				{
					return;
				}
				_actionState = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<gamedataObjectActionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataObjectActionType>) CR2WTypeManager.Create("gamedataObjectActionType", "type", cr2w, this);
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

		[Ordinal(12)] 
		[RED("cost")] 
		public CInt32 Cost
		{
			get
			{
				if (_cost == null)
				{
					_cost = (CInt32) CR2WTypeManager.Create("Int32", "cost", cr2w, this);
				}
				return _cost;
			}
			set
			{
				if (_cost == value)
				{
					return;
				}
				_cost = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("costRaw")] 
		public CInt32 CostRaw
		{
			get
			{
				if (_costRaw == null)
				{
					_costRaw = (CInt32) CR2WTypeManager.Create("Int32", "costRaw", cr2w, this);
				}
				return _costRaw;
			}
			set
			{
				if (_costRaw == value)
				{
					return;
				}
				_costRaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("uploadTime")] 
		public CFloat UploadTime
		{
			get
			{
				if (_uploadTime == null)
				{
					_uploadTime = (CFloat) CR2WTypeManager.Create("Float", "uploadTime", cr2w, this);
				}
				return _uploadTime;
			}
			set
			{
				if (_uploadTime == value)
				{
					return;
				}
				_uploadTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ICELevelVisible")] 
		public CBool ICELevelVisible
		{
			get
			{
				if (_iCELevelVisible == null)
				{
					_iCELevelVisible = (CBool) CR2WTypeManager.Create("Bool", "ICELevelVisible", cr2w, this);
				}
				return _iCELevelVisible;
			}
			set
			{
				if (_iCELevelVisible == value)
				{
					return;
				}
				_iCELevelVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("ICELevel")] 
		public CFloat ICELevel
		{
			get
			{
				if (_iCELevel == null)
				{
					_iCELevel = (CFloat) CR2WTypeManager.Create("Float", "ICELevel", cr2w, this);
				}
				return _iCELevel;
			}
			set
			{
				if (_iCELevel == value)
				{
					return;
				}
				_iCELevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("vulnerabilities")] 
		public CArray<TweakDBID> Vulnerabilities
		{
			get
			{
				if (_vulnerabilities == null)
				{
					_vulnerabilities = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "vulnerabilities", cr2w, this);
				}
				return _vulnerabilities;
			}
			set
			{
				if (_vulnerabilities == value)
				{
					return;
				}
				_vulnerabilities = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get
			{
				if (_isInstant == null)
				{
					_isInstant = (CBool) CR2WTypeManager.Create("Bool", "isInstant", cr2w, this);
				}
				return _isInstant;
			}
			set
			{
				if (_isInstant == value)
				{
					return;
				}
				_isInstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (CFloat) CR2WTypeManager.Create("Float", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("cooldownTweak")] 
		public TweakDBID CooldownTweak
		{
			get
			{
				if (_cooldownTweak == null)
				{
					_cooldownTweak = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "cooldownTweak", cr2w, this);
				}
				return _cooldownTweak;
			}
			set
			{
				if (_cooldownTweak == value)
				{
					return;
				}
				_cooldownTweak = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("actionMatchesTarget")] 
		public CBool ActionMatchesTarget
		{
			get
			{
				if (_actionMatchesTarget == null)
				{
					_actionMatchesTarget = (CBool) CR2WTypeManager.Create("Bool", "actionMatchesTarget", cr2w, this);
				}
				return _actionMatchesTarget;
			}
			set
			{
				if (_actionMatchesTarget == value)
				{
					return;
				}
				_actionMatchesTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("maxListSize")] 
		public CInt32 MaxListSize
		{
			get
			{
				if (_maxListSize == null)
				{
					_maxListSize = (CInt32) CR2WTypeManager.Create("Int32", "maxListSize", cr2w, this);
				}
				return _maxListSize;
			}
			set
			{
				if (_maxListSize == value)
				{
					return;
				}
				_maxListSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("category")] 
		public wCHandle<gamedataHackCategory_Record> Category
		{
			get
			{
				if (_category == null)
				{
					_category = (wCHandle<gamedataHackCategory_Record>) CR2WTypeManager.Create("whandle:gamedataHackCategory_Record", "category", cr2w, this);
				}
				return _category;
			}
			set
			{
				if (_category == value)
				{
					return;
				}
				_category = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("actionCompletionEffects")] 
		public CArray<wCHandle<gamedataObjectActionEffect_Record>> ActionCompletionEffects
		{
			get
			{
				if (_actionCompletionEffects == null)
				{
					_actionCompletionEffects = (CArray<wCHandle<gamedataObjectActionEffect_Record>>) CR2WTypeManager.Create("array:whandle:gamedataObjectActionEffect_Record", "actionCompletionEffects", cr2w, this);
				}
				return _actionCompletionEffects;
			}
			set
			{
				if (_actionCompletionEffects == value)
				{
					return;
				}
				_actionCompletionEffects = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("networkBreached")] 
		public CBool NetworkBreached
		{
			get
			{
				if (_networkBreached == null)
				{
					_networkBreached = (CBool) CR2WTypeManager.Create("Bool", "networkBreached", cr2w, this);
				}
				return _networkBreached;
			}
			set
			{
				if (_networkBreached == value)
				{
					return;
				}
				_networkBreached = value;
				PropertySet(this);
			}
		}

		public QuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
