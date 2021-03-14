using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DiodeLightPreset : CVariable
	{
		private CBool _state;
		private CArray<CInt32> _colorMax;
		private CArray<CInt32> _colorMin;
		private CBool _overrideColorMin;
		private CFloat _strength;
		private CName _curve;
		private CFloat _time;
		private CBool _loop;
		private CFloat _duration;
		private CBool _force;

		[Ordinal(0)] 
		[RED("state")] 
		public CBool State
		{
			get
			{
				if (_state == null)
				{
					_state = (CBool) CR2WTypeManager.Create("Bool", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("colorMax")] 
		public CArray<CInt32> ColorMax
		{
			get
			{
				if (_colorMax == null)
				{
					_colorMax = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "colorMax", cr2w, this);
				}
				return _colorMax;
			}
			set
			{
				if (_colorMax == value)
				{
					return;
				}
				_colorMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("colorMin")] 
		public CArray<CInt32> ColorMin
		{
			get
			{
				if (_colorMin == null)
				{
					_colorMin = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "colorMin", cr2w, this);
				}
				return _colorMin;
			}
			set
			{
				if (_colorMin == value)
				{
					return;
				}
				_colorMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("overrideColorMin")] 
		public CBool OverrideColorMin
		{
			get
			{
				if (_overrideColorMin == null)
				{
					_overrideColorMin = (CBool) CR2WTypeManager.Create("Bool", "overrideColorMin", cr2w, this);
				}
				return _overrideColorMin;
			}
			set
			{
				if (_overrideColorMin == value)
				{
					return;
				}
				_overrideColorMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (CFloat) CR2WTypeManager.Create("Float", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("curve")] 
		public CName Curve
		{
			get
			{
				if (_curve == null)
				{
					_curve = (CName) CR2WTypeManager.Create("CName", "curve", cr2w, this);
				}
				return _curve;
			}
			set
			{
				if (_curve == value)
				{
					return;
				}
				_curve = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("loop")] 
		public CBool Loop
		{
			get
			{
				if (_loop == null)
				{
					_loop = (CBool) CR2WTypeManager.Create("Bool", "loop", cr2w, this);
				}
				return _loop;
			}
			set
			{
				if (_loop == value)
				{
					return;
				}
				_loop = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("force")] 
		public CBool Force
		{
			get
			{
				if (_force == null)
				{
					_force = (CBool) CR2WTypeManager.Create("Bool", "force", cr2w, this);
				}
				return _force;
			}
			set
			{
				if (_force == value)
				{
					return;
				}
				_force = value;
				PropertySet(this);
			}
		}

		public DiodeLightPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
