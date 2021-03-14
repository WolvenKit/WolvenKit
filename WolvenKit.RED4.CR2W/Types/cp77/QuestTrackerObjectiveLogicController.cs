using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestTrackerObjectiveLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _objectiveTitle;
		private inkWidgetReference _trackingIcon;
		private inkWidgetReference _trackingFrame;
		private wCHandle<gameJournalQuestObjective> _objectiveEntry;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _introAnimProxy;
		private inkanimPlaybackOptions _animOptions;
		private CBool _readyToRemove;

		[Ordinal(1)] 
		[RED("objectiveTitle")] 
		public inkTextWidgetReference ObjectiveTitle
		{
			get
			{
				if (_objectiveTitle == null)
				{
					_objectiveTitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "objectiveTitle", cr2w, this);
				}
				return _objectiveTitle;
			}
			set
			{
				if (_objectiveTitle == value)
				{
					return;
				}
				_objectiveTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("trackingIcon")] 
		public inkWidgetReference TrackingIcon
		{
			get
			{
				if (_trackingIcon == null)
				{
					_trackingIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "trackingIcon", cr2w, this);
				}
				return _trackingIcon;
			}
			set
			{
				if (_trackingIcon == value)
				{
					return;
				}
				_trackingIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("trackingFrame")] 
		public inkWidgetReference TrackingFrame
		{
			get
			{
				if (_trackingFrame == null)
				{
					_trackingFrame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "trackingFrame", cr2w, this);
				}
				return _trackingFrame;
			}
			set
			{
				if (_trackingFrame == value)
				{
					return;
				}
				_trackingFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("objectiveEntry")] 
		public wCHandle<gameJournalQuestObjective> ObjectiveEntry
		{
			get
			{
				if (_objectiveEntry == null)
				{
					_objectiveEntry = (wCHandle<gameJournalQuestObjective>) CR2WTypeManager.Create("whandle:gameJournalQuestObjective", "objectiveEntry", cr2w, this);
				}
				return _objectiveEntry;
			}
			set
			{
				if (_objectiveEntry == value)
				{
					return;
				}
				_objectiveEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "AnimProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("IntroAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get
			{
				if (_introAnimProxy == null)
				{
					_introAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "IntroAnimProxy", cr2w, this);
				}
				return _introAnimProxy;
			}
			set
			{
				if (_introAnimProxy == value)
				{
					return;
				}
				_introAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get
			{
				if (_animOptions == null)
				{
					_animOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "AnimOptions", cr2w, this);
				}
				return _animOptions;
			}
			set
			{
				if (_animOptions == value)
				{
					return;
				}
				_animOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("readyToRemove")] 
		public CBool ReadyToRemove
		{
			get
			{
				if (_readyToRemove == null)
				{
					_readyToRemove = (CBool) CR2WTypeManager.Create("Bool", "readyToRemove", cr2w, this);
				}
				return _readyToRemove;
			}
			set
			{
				if (_readyToRemove == value)
				{
					return;
				}
				_readyToRemove = value;
				PropertySet(this);
			}
		}

		public QuestTrackerObjectiveLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
