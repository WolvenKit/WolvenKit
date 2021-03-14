using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionData : CVariable
	{
		private CBool _hasInteraction;
		private CBool _hasUI;
		private CBool _isQuickHack;
		private CBool _isSpiderbotAction;
		private NodeRef _spiderbotLocationOverrideReference;
		private CEnum<EDeviceChallengeSkill> _attachedToSkillCheck;
		private TweakDBID _widgetRecord;
		private TweakDBID _objectActionRecord;
		private CName _currentDisplayName;
		private CString _interactionRecord;

		[Ordinal(0)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get
			{
				if (_hasInteraction == null)
				{
					_hasInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasInteraction", cr2w, this);
				}
				return _hasInteraction;
			}
			set
			{
				if (_hasInteraction == value)
				{
					return;
				}
				_hasInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasUI")] 
		public CBool HasUI
		{
			get
			{
				if (_hasUI == null)
				{
					_hasUI = (CBool) CR2WTypeManager.Create("Bool", "hasUI", cr2w, this);
				}
				return _hasUI;
			}
			set
			{
				if (_hasUI == value)
				{
					return;
				}
				_hasUI = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isQuickHack")] 
		public CBool IsQuickHack
		{
			get
			{
				if (_isQuickHack == null)
				{
					_isQuickHack = (CBool) CR2WTypeManager.Create("Bool", "isQuickHack", cr2w, this);
				}
				return _isQuickHack;
			}
			set
			{
				if (_isQuickHack == value)
				{
					return;
				}
				_isQuickHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isSpiderbotAction")] 
		public CBool IsSpiderbotAction
		{
			get
			{
				if (_isSpiderbotAction == null)
				{
					_isSpiderbotAction = (CBool) CR2WTypeManager.Create("Bool", "isSpiderbotAction", cr2w, this);
				}
				return _isSpiderbotAction;
			}
			set
			{
				if (_isSpiderbotAction == value)
				{
					return;
				}
				_isSpiderbotAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("spiderbotLocationOverrideReference")] 
		public NodeRef SpiderbotLocationOverrideReference
		{
			get
			{
				if (_spiderbotLocationOverrideReference == null)
				{
					_spiderbotLocationOverrideReference = (NodeRef) CR2WTypeManager.Create("NodeRef", "spiderbotLocationOverrideReference", cr2w, this);
				}
				return _spiderbotLocationOverrideReference;
			}
			set
			{
				if (_spiderbotLocationOverrideReference == value)
				{
					return;
				}
				_spiderbotLocationOverrideReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("attachedToSkillCheck")] 
		public CEnum<EDeviceChallengeSkill> AttachedToSkillCheck
		{
			get
			{
				if (_attachedToSkillCheck == null)
				{
					_attachedToSkillCheck = (CEnum<EDeviceChallengeSkill>) CR2WTypeManager.Create("EDeviceChallengeSkill", "attachedToSkillCheck", cr2w, this);
				}
				return _attachedToSkillCheck;
			}
			set
			{
				if (_attachedToSkillCheck == value)
				{
					return;
				}
				_attachedToSkillCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("widgetRecord")] 
		public TweakDBID WidgetRecord
		{
			get
			{
				if (_widgetRecord == null)
				{
					_widgetRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "widgetRecord", cr2w, this);
				}
				return _widgetRecord;
			}
			set
			{
				if (_widgetRecord == value)
				{
					return;
				}
				_widgetRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("objectActionRecord")] 
		public TweakDBID ObjectActionRecord
		{
			get
			{
				if (_objectActionRecord == null)
				{
					_objectActionRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "objectActionRecord", cr2w, this);
				}
				return _objectActionRecord;
			}
			set
			{
				if (_objectActionRecord == value)
				{
					return;
				}
				_objectActionRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("currentDisplayName")] 
		public CName CurrentDisplayName
		{
			get
			{
				if (_currentDisplayName == null)
				{
					_currentDisplayName = (CName) CR2WTypeManager.Create("CName", "currentDisplayName", cr2w, this);
				}
				return _currentDisplayName;
			}
			set
			{
				if (_currentDisplayName == value)
				{
					return;
				}
				_currentDisplayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("interactionRecord")] 
		public CString InteractionRecord
		{
			get
			{
				if (_interactionRecord == null)
				{
					_interactionRecord = (CString) CR2WTypeManager.Create("String", "interactionRecord", cr2w, this);
				}
				return _interactionRecord;
			}
			set
			{
				if (_interactionRecord == value)
				{
					return;
				}
				_interactionRecord = value;
				PropertySet(this);
			}
		}

		public SDeviceActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
