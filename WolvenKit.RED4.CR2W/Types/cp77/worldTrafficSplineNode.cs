using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficSplineNode : worldTrafficSourceNode
	{
		private CEnum<worldTrafficSplineNodeUsage> _usage;
		private CFloat _maxSlotMaxSpeed;
		private CFloat _width;
		private CFloat _pathSamplingDistance;
		private CBool _bidirectional;
		private CFloat _autoConnectionRange;
		private CArray<CName> _markings;
		private CArray<worldTrafficLaneExitDefinition> _outLanes;
		private CArray<worldTrafficLightDefinition> _lights;
		private CBool _neverDeadEnd;
		private CBool _trafficDisabled;
		private CFloat _laneSamplingAngle;

		[Ordinal(9)] 
		[RED("usage")] 
		public CEnum<worldTrafficSplineNodeUsage> Usage
		{
			get
			{
				if (_usage == null)
				{
					_usage = (CEnum<worldTrafficSplineNodeUsage>) CR2WTypeManager.Create("worldTrafficSplineNodeUsage", "usage", cr2w, this);
				}
				return _usage;
			}
			set
			{
				if (_usage == value)
				{
					return;
				}
				_usage = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("maxSlotMaxSpeed")] 
		public CFloat MaxSlotMaxSpeed
		{
			get
			{
				if (_maxSlotMaxSpeed == null)
				{
					_maxSlotMaxSpeed = (CFloat) CR2WTypeManager.Create("Float", "maxSlotMaxSpeed", cr2w, this);
				}
				return _maxSlotMaxSpeed;
			}
			set
			{
				if (_maxSlotMaxSpeed == value)
				{
					return;
				}
				_maxSlotMaxSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("width")] 
		public CFloat Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CFloat) CR2WTypeManager.Create("Float", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("pathSamplingDistance")] 
		public CFloat PathSamplingDistance
		{
			get
			{
				if (_pathSamplingDistance == null)
				{
					_pathSamplingDistance = (CFloat) CR2WTypeManager.Create("Float", "pathSamplingDistance", cr2w, this);
				}
				return _pathSamplingDistance;
			}
			set
			{
				if (_pathSamplingDistance == value)
				{
					return;
				}
				_pathSamplingDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bidirectional")] 
		public CBool Bidirectional
		{
			get
			{
				if (_bidirectional == null)
				{
					_bidirectional = (CBool) CR2WTypeManager.Create("Bool", "bidirectional", cr2w, this);
				}
				return _bidirectional;
			}
			set
			{
				if (_bidirectional == value)
				{
					return;
				}
				_bidirectional = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("autoConnectionRange")] 
		public CFloat AutoConnectionRange
		{
			get
			{
				if (_autoConnectionRange == null)
				{
					_autoConnectionRange = (CFloat) CR2WTypeManager.Create("Float", "autoConnectionRange", cr2w, this);
				}
				return _autoConnectionRange;
			}
			set
			{
				if (_autoConnectionRange == value)
				{
					return;
				}
				_autoConnectionRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get
			{
				if (_markings == null)
				{
					_markings = (CArray<CName>) CR2WTypeManager.Create("array:CName", "markings", cr2w, this);
				}
				return _markings;
			}
			set
			{
				if (_markings == value)
				{
					return;
				}
				_markings = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("outLanes")] 
		public CArray<worldTrafficLaneExitDefinition> OutLanes
		{
			get
			{
				if (_outLanes == null)
				{
					_outLanes = (CArray<worldTrafficLaneExitDefinition>) CR2WTypeManager.Create("array:worldTrafficLaneExitDefinition", "outLanes", cr2w, this);
				}
				return _outLanes;
			}
			set
			{
				if (_outLanes == value)
				{
					return;
				}
				_outLanes = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("lights")] 
		public CArray<worldTrafficLightDefinition> Lights
		{
			get
			{
				if (_lights == null)
				{
					_lights = (CArray<worldTrafficLightDefinition>) CR2WTypeManager.Create("array:worldTrafficLightDefinition", "lights", cr2w, this);
				}
				return _lights;
			}
			set
			{
				if (_lights == value)
				{
					return;
				}
				_lights = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("neverDeadEnd")] 
		public CBool NeverDeadEnd
		{
			get
			{
				if (_neverDeadEnd == null)
				{
					_neverDeadEnd = (CBool) CR2WTypeManager.Create("Bool", "neverDeadEnd", cr2w, this);
				}
				return _neverDeadEnd;
			}
			set
			{
				if (_neverDeadEnd == value)
				{
					return;
				}
				_neverDeadEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("trafficDisabled")] 
		public CBool TrafficDisabled
		{
			get
			{
				if (_trafficDisabled == null)
				{
					_trafficDisabled = (CBool) CR2WTypeManager.Create("Bool", "trafficDisabled", cr2w, this);
				}
				return _trafficDisabled;
			}
			set
			{
				if (_trafficDisabled == value)
				{
					return;
				}
				_trafficDisabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("laneSamplingAngle")] 
		public CFloat LaneSamplingAngle
		{
			get
			{
				if (_laneSamplingAngle == null)
				{
					_laneSamplingAngle = (CFloat) CR2WTypeManager.Create("Float", "laneSamplingAngle", cr2w, this);
				}
				return _laneSamplingAngle;
			}
			set
			{
				if (_laneSamplingAngle == value)
				{
					return;
				}
				_laneSamplingAngle = value;
				PropertySet(this);
			}
		}

		public worldTrafficSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
