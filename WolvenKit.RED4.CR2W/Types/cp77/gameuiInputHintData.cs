using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintData : CVariable
	{
		private CName _action;
		private CName _source;
		private CName _groupId;
		private CName _tutorialAction;
		private CString _localizedLabel;
		private CInt32 _queuePriority;
		private CInt32 _sortingPriority;
		private CInt32 _tutorialActionCount;
		private CEnum<inkInputHintHoldIndicationType> _holdIndicationType;
		private CBool _enableHoldAnimation;

		[Ordinal(0)] 
		[RED("action")] 
		public CName Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CName) CR2WTypeManager.Create("CName", "action", cr2w, this);
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
		[RED("source")] 
		public CName Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CName) CR2WTypeManager.Create("CName", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get
			{
				if (_groupId == null)
				{
					_groupId = (CName) CR2WTypeManager.Create("CName", "groupId", cr2w, this);
				}
				return _groupId;
			}
			set
			{
				if (_groupId == value)
				{
					return;
				}
				_groupId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tutorialAction")] 
		public CName TutorialAction
		{
			get
			{
				if (_tutorialAction == null)
				{
					_tutorialAction = (CName) CR2WTypeManager.Create("CName", "tutorialAction", cr2w, this);
				}
				return _tutorialAction;
			}
			set
			{
				if (_tutorialAction == value)
				{
					return;
				}
				_tutorialAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("localizedLabel")] 
		public CString LocalizedLabel
		{
			get
			{
				if (_localizedLabel == null)
				{
					_localizedLabel = (CString) CR2WTypeManager.Create("String", "localizedLabel", cr2w, this);
				}
				return _localizedLabel;
			}
			set
			{
				if (_localizedLabel == value)
				{
					return;
				}
				_localizedLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("queuePriority")] 
		public CInt32 QueuePriority
		{
			get
			{
				if (_queuePriority == null)
				{
					_queuePriority = (CInt32) CR2WTypeManager.Create("Int32", "queuePriority", cr2w, this);
				}
				return _queuePriority;
			}
			set
			{
				if (_queuePriority == value)
				{
					return;
				}
				_queuePriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sortingPriority")] 
		public CInt32 SortingPriority
		{
			get
			{
				if (_sortingPriority == null)
				{
					_sortingPriority = (CInt32) CR2WTypeManager.Create("Int32", "sortingPriority", cr2w, this);
				}
				return _sortingPriority;
			}
			set
			{
				if (_sortingPriority == value)
				{
					return;
				}
				_sortingPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tutorialActionCount")] 
		public CInt32 TutorialActionCount
		{
			get
			{
				if (_tutorialActionCount == null)
				{
					_tutorialActionCount = (CInt32) CR2WTypeManager.Create("Int32", "tutorialActionCount", cr2w, this);
				}
				return _tutorialActionCount;
			}
			set
			{
				if (_tutorialActionCount == value)
				{
					return;
				}
				_tutorialActionCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("holdIndicationType")] 
		public CEnum<inkInputHintHoldIndicationType> HoldIndicationType
		{
			get
			{
				if (_holdIndicationType == null)
				{
					_holdIndicationType = (CEnum<inkInputHintHoldIndicationType>) CR2WTypeManager.Create("inkInputHintHoldIndicationType", "holdIndicationType", cr2w, this);
				}
				return _holdIndicationType;
			}
			set
			{
				if (_holdIndicationType == value)
				{
					return;
				}
				_holdIndicationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("enableHoldAnimation")] 
		public CBool EnableHoldAnimation
		{
			get
			{
				if (_enableHoldAnimation == null)
				{
					_enableHoldAnimation = (CBool) CR2WTypeManager.Create("Bool", "enableHoldAnimation", cr2w, this);
				}
				return _enableHoldAnimation;
			}
			set
			{
				if (_enableHoldAnimation == value)
				{
					return;
				}
				_enableHoldAnimation = value;
				PropertySet(this);
			}
		}

		public gameuiInputHintData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
