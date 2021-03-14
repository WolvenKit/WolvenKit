using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestDetailsObjectiveController : inkWidgetLogicController
	{
		private inkTextWidgetReference _objectiveName;
		private inkWidgetReference _trackingMarker;
		private inkWidgetReference _root;
		private wCHandle<gameJournalQuestObjective> _objective;
		private CBool _hovered;

		[Ordinal(1)] 
		[RED("objectiveName")] 
		public inkTextWidgetReference ObjectiveName
		{
			get
			{
				if (_objectiveName == null)
				{
					_objectiveName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "objectiveName", cr2w, this);
				}
				return _objectiveName;
			}
			set
			{
				if (_objectiveName == value)
				{
					return;
				}
				_objectiveName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("trackingMarker")] 
		public inkWidgetReference TrackingMarker
		{
			get
			{
				if (_trackingMarker == null)
				{
					_trackingMarker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "trackingMarker", cr2w, this);
				}
				return _trackingMarker;
			}
			set
			{
				if (_trackingMarker == value)
				{
					return;
				}
				_trackingMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("objective")] 
		public wCHandle<gameJournalQuestObjective> Objective
		{
			get
			{
				if (_objective == null)
				{
					_objective = (wCHandle<gameJournalQuestObjective>) CR2WTypeManager.Create("whandle:gameJournalQuestObjective", "objective", cr2w, this);
				}
				return _objective;
			}
			set
			{
				if (_objective == value)
				{
					return;
				}
				_objective = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get
			{
				if (_hovered == null)
				{
					_hovered = (CBool) CR2WTypeManager.Create("Bool", "hovered", cr2w, this);
				}
				return _hovered;
			}
			set
			{
				if (_hovered == value)
				{
					return;
				}
				_hovered = value;
				PropertySet(this);
			}
		}

		public QuestDetailsObjectiveController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
