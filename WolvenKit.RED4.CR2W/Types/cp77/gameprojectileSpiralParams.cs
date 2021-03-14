using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpiralParams : IScriptable
	{
		private CBool _enabled;
		private CFloat _radius;
		private CFloat _cycleTimeMin;
		private CFloat _cycleTimeMax;
		private CFloat _rampUpDistanceStart;
		private CFloat _rampUpDistanceEnd;
		private CFloat _rampDownDistanceStart;
		private CFloat _rampDownDistanceEnd;
		private CFloat _rampDownFactor;
		private CBool _randomizePhase;
		private CBool _randomizeDirection;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cycleTimeMin")] 
		public CFloat CycleTimeMin
		{
			get
			{
				if (_cycleTimeMin == null)
				{
					_cycleTimeMin = (CFloat) CR2WTypeManager.Create("Float", "cycleTimeMin", cr2w, this);
				}
				return _cycleTimeMin;
			}
			set
			{
				if (_cycleTimeMin == value)
				{
					return;
				}
				_cycleTimeMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cycleTimeMax")] 
		public CFloat CycleTimeMax
		{
			get
			{
				if (_cycleTimeMax == null)
				{
					_cycleTimeMax = (CFloat) CR2WTypeManager.Create("Float", "cycleTimeMax", cr2w, this);
				}
				return _cycleTimeMax;
			}
			set
			{
				if (_cycleTimeMax == value)
				{
					return;
				}
				_cycleTimeMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rampUpDistanceStart")] 
		public CFloat RampUpDistanceStart
		{
			get
			{
				if (_rampUpDistanceStart == null)
				{
					_rampUpDistanceStart = (CFloat) CR2WTypeManager.Create("Float", "rampUpDistanceStart", cr2w, this);
				}
				return _rampUpDistanceStart;
			}
			set
			{
				if (_rampUpDistanceStart == value)
				{
					return;
				}
				_rampUpDistanceStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rampUpDistanceEnd")] 
		public CFloat RampUpDistanceEnd
		{
			get
			{
				if (_rampUpDistanceEnd == null)
				{
					_rampUpDistanceEnd = (CFloat) CR2WTypeManager.Create("Float", "rampUpDistanceEnd", cr2w, this);
				}
				return _rampUpDistanceEnd;
			}
			set
			{
				if (_rampUpDistanceEnd == value)
				{
					return;
				}
				_rampUpDistanceEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rampDownDistanceStart")] 
		public CFloat RampDownDistanceStart
		{
			get
			{
				if (_rampDownDistanceStart == null)
				{
					_rampDownDistanceStart = (CFloat) CR2WTypeManager.Create("Float", "rampDownDistanceStart", cr2w, this);
				}
				return _rampDownDistanceStart;
			}
			set
			{
				if (_rampDownDistanceStart == value)
				{
					return;
				}
				_rampDownDistanceStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("rampDownDistanceEnd")] 
		public CFloat RampDownDistanceEnd
		{
			get
			{
				if (_rampDownDistanceEnd == null)
				{
					_rampDownDistanceEnd = (CFloat) CR2WTypeManager.Create("Float", "rampDownDistanceEnd", cr2w, this);
				}
				return _rampDownDistanceEnd;
			}
			set
			{
				if (_rampDownDistanceEnd == value)
				{
					return;
				}
				_rampDownDistanceEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("rampDownFactor")] 
		public CFloat RampDownFactor
		{
			get
			{
				if (_rampDownFactor == null)
				{
					_rampDownFactor = (CFloat) CR2WTypeManager.Create("Float", "rampDownFactor", cr2w, this);
				}
				return _rampDownFactor;
			}
			set
			{
				if (_rampDownFactor == value)
				{
					return;
				}
				_rampDownFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("randomizePhase")] 
		public CBool RandomizePhase
		{
			get
			{
				if (_randomizePhase == null)
				{
					_randomizePhase = (CBool) CR2WTypeManager.Create("Bool", "randomizePhase", cr2w, this);
				}
				return _randomizePhase;
			}
			set
			{
				if (_randomizePhase == value)
				{
					return;
				}
				_randomizePhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("randomizeDirection")] 
		public CBool RandomizeDirection
		{
			get
			{
				if (_randomizeDirection == null)
				{
					_randomizeDirection = (CBool) CR2WTypeManager.Create("Bool", "randomizeDirection", cr2w, this);
				}
				return _randomizeDirection;
			}
			set
			{
				if (_randomizeDirection == value)
				{
					return;
				}
				_randomizeDirection = value;
				PropertySet(this);
			}
		}

		public gameprojectileSpiralParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
