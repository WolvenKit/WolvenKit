using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListItemController : inkWidgetLogicController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _level;
		private inkWidgetReference _trackedMarker;
		private inkImageWidgetReference _districtIcon;
		private inkImageWidgetReference _stateIcon;
		private inkTextWidgetReference _distance;
		private inkWidgetReference _root;
		private inkWidgetReference _newIcon;
		private CHandle<QuestListItemData> _data;
		private CHandle<QuestListDistanceData> _closestObjective;
		private CBool _hovered;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get
			{
				if (_title == null)
				{
					_title = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "title", cr2w, this);
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

		[Ordinal(2)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get
			{
				if (_level == null)
				{
					_level = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("trackedMarker")] 
		public inkWidgetReference TrackedMarker
		{
			get
			{
				if (_trackedMarker == null)
				{
					_trackedMarker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "trackedMarker", cr2w, this);
				}
				return _trackedMarker;
			}
			set
			{
				if (_trackedMarker == value)
				{
					return;
				}
				_trackedMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("districtIcon")] 
		public inkImageWidgetReference DistrictIcon
		{
			get
			{
				if (_districtIcon == null)
				{
					_districtIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "districtIcon", cr2w, this);
				}
				return _districtIcon;
			}
			set
			{
				if (_districtIcon == value)
				{
					return;
				}
				_districtIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stateIcon")] 
		public inkImageWidgetReference StateIcon
		{
			get
			{
				if (_stateIcon == null)
				{
					_stateIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "stateIcon", cr2w, this);
				}
				return _stateIcon;
			}
			set
			{
				if (_stateIcon == value)
				{
					return;
				}
				_stateIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("distance")] 
		public inkTextWidgetReference Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("newIcon")] 
		public inkWidgetReference NewIcon
		{
			get
			{
				if (_newIcon == null)
				{
					_newIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "newIcon", cr2w, this);
				}
				return _newIcon;
			}
			set
			{
				if (_newIcon == value)
				{
					return;
				}
				_newIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<QuestListItemData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<QuestListItemData>) CR2WTypeManager.Create("handle:QuestListItemData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("closestObjective")] 
		public CHandle<QuestListDistanceData> ClosestObjective
		{
			get
			{
				if (_closestObjective == null)
				{
					_closestObjective = (CHandle<QuestListDistanceData>) CR2WTypeManager.Create("handle:QuestListDistanceData", "closestObjective", cr2w, this);
				}
				return _closestObjective;
			}
			set
			{
				if (_closestObjective == value)
				{
					return;
				}
				_closestObjective = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
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

		public QuestListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
