using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questProximityProgressBar_NodeType : questIUIManagerNodeType
	{
		private CBool _show;
		private CFloat _duration;
		private CBool _reset;
		private CFloat _distance;
		private CEnum<EComparisonType> _distanceComparisonType;
		private gameEntityReference _target;
		private CBool _isPlayerActivator;
		private gameEntityReference _activator;

		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get
			{
				if (_show == null)
				{
					_show = (CBool) CR2WTypeManager.Create("Bool", "show", cr2w, this);
				}
				return _show;
			}
			set
			{
				if (_show == value)
				{
					return;
				}
				_show = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("reset")] 
		public CBool Reset
		{
			get
			{
				if (_reset == null)
				{
					_reset = (CBool) CR2WTypeManager.Create("Bool", "reset", cr2w, this);
				}
				return _reset;
			}
			set
			{
				if (_reset == value)
				{
					return;
				}
				_reset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
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

		[Ordinal(4)] 
		[RED("distanceComparisonType")] 
		public CEnum<EComparisonType> DistanceComparisonType
		{
			get
			{
				if (_distanceComparisonType == null)
				{
					_distanceComparisonType = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "distanceComparisonType", cr2w, this);
				}
				return _distanceComparisonType;
			}
			set
			{
				if (_distanceComparisonType == value)
				{
					return;
				}
				_distanceComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("target")] 
		public gameEntityReference Target
		{
			get
			{
				if (_target == null)
				{
					_target = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isPlayerActivator")] 
		public CBool IsPlayerActivator
		{
			get
			{
				if (_isPlayerActivator == null)
				{
					_isPlayerActivator = (CBool) CR2WTypeManager.Create("Bool", "isPlayerActivator", cr2w, this);
				}
				return _isPlayerActivator;
			}
			set
			{
				if (_isPlayerActivator == value)
				{
					return;
				}
				_isPlayerActivator = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("activator")] 
		public gameEntityReference Activator
		{
			get
			{
				if (_activator == null)
				{
					_activator = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "activator", cr2w, this);
				}
				return _activator;
			}
			set
			{
				if (_activator == value)
				{
					return;
				}
				_activator = value;
				PropertySet(this);
			}
		}

		public questProximityProgressBar_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
