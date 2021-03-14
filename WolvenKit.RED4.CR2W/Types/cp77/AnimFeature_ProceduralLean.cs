using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ProceduralLean : animAnimFeature
	{
		private CFloat _angle_threshold;
		private CFloat _max_turn_angle;
		private CFloat _hips_shift_side;
		private CFloat _hips_shift_down;
		private CFloat _hips_tilt;
		private CFloat _hips_turn;
		private CFloat _spine_tilt;
		private CFloat _spine_turn;
		private CFloat _arms_counter_turn;
		private CFloat _transform_multiplyer;
		private CFloat _damp_value_walk;
		private CFloat _damp_value_sprint;

		[Ordinal(0)] 
		[RED("angle_threshold")] 
		public CFloat Angle_threshold
		{
			get
			{
				if (_angle_threshold == null)
				{
					_angle_threshold = (CFloat) CR2WTypeManager.Create("Float", "angle_threshold", cr2w, this);
				}
				return _angle_threshold;
			}
			set
			{
				if (_angle_threshold == value)
				{
					return;
				}
				_angle_threshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("max_turn_angle")] 
		public CFloat Max_turn_angle
		{
			get
			{
				if (_max_turn_angle == null)
				{
					_max_turn_angle = (CFloat) CR2WTypeManager.Create("Float", "max_turn_angle", cr2w, this);
				}
				return _max_turn_angle;
			}
			set
			{
				if (_max_turn_angle == value)
				{
					return;
				}
				_max_turn_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hips_shift_side")] 
		public CFloat Hips_shift_side
		{
			get
			{
				if (_hips_shift_side == null)
				{
					_hips_shift_side = (CFloat) CR2WTypeManager.Create("Float", "hips_shift_side", cr2w, this);
				}
				return _hips_shift_side;
			}
			set
			{
				if (_hips_shift_side == value)
				{
					return;
				}
				_hips_shift_side = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hips_shift_down")] 
		public CFloat Hips_shift_down
		{
			get
			{
				if (_hips_shift_down == null)
				{
					_hips_shift_down = (CFloat) CR2WTypeManager.Create("Float", "hips_shift_down", cr2w, this);
				}
				return _hips_shift_down;
			}
			set
			{
				if (_hips_shift_down == value)
				{
					return;
				}
				_hips_shift_down = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hips_tilt")] 
		public CFloat Hips_tilt
		{
			get
			{
				if (_hips_tilt == null)
				{
					_hips_tilt = (CFloat) CR2WTypeManager.Create("Float", "hips_tilt", cr2w, this);
				}
				return _hips_tilt;
			}
			set
			{
				if (_hips_tilt == value)
				{
					return;
				}
				_hips_tilt = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hips_turn")] 
		public CFloat Hips_turn
		{
			get
			{
				if (_hips_turn == null)
				{
					_hips_turn = (CFloat) CR2WTypeManager.Create("Float", "hips_turn", cr2w, this);
				}
				return _hips_turn;
			}
			set
			{
				if (_hips_turn == value)
				{
					return;
				}
				_hips_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("spine_tilt")] 
		public CFloat Spine_tilt
		{
			get
			{
				if (_spine_tilt == null)
				{
					_spine_tilt = (CFloat) CR2WTypeManager.Create("Float", "spine_tilt", cr2w, this);
				}
				return _spine_tilt;
			}
			set
			{
				if (_spine_tilt == value)
				{
					return;
				}
				_spine_tilt = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("spine_turn")] 
		public CFloat Spine_turn
		{
			get
			{
				if (_spine_turn == null)
				{
					_spine_turn = (CFloat) CR2WTypeManager.Create("Float", "spine_turn", cr2w, this);
				}
				return _spine_turn;
			}
			set
			{
				if (_spine_turn == value)
				{
					return;
				}
				_spine_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("arms_counter_turn")] 
		public CFloat Arms_counter_turn
		{
			get
			{
				if (_arms_counter_turn == null)
				{
					_arms_counter_turn = (CFloat) CR2WTypeManager.Create("Float", "arms_counter_turn", cr2w, this);
				}
				return _arms_counter_turn;
			}
			set
			{
				if (_arms_counter_turn == value)
				{
					return;
				}
				_arms_counter_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("transform_multiplyer")] 
		public CFloat Transform_multiplyer
		{
			get
			{
				if (_transform_multiplyer == null)
				{
					_transform_multiplyer = (CFloat) CR2WTypeManager.Create("Float", "transform_multiplyer", cr2w, this);
				}
				return _transform_multiplyer;
			}
			set
			{
				if (_transform_multiplyer == value)
				{
					return;
				}
				_transform_multiplyer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("damp_value_walk")] 
		public CFloat Damp_value_walk
		{
			get
			{
				if (_damp_value_walk == null)
				{
					_damp_value_walk = (CFloat) CR2WTypeManager.Create("Float", "damp_value_walk", cr2w, this);
				}
				return _damp_value_walk;
			}
			set
			{
				if (_damp_value_walk == value)
				{
					return;
				}
				_damp_value_walk = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("damp_value_sprint")] 
		public CFloat Damp_value_sprint
		{
			get
			{
				if (_damp_value_sprint == null)
				{
					_damp_value_sprint = (CFloat) CR2WTypeManager.Create("Float", "damp_value_sprint", cr2w, this);
				}
				return _damp_value_sprint;
			}
			set
			{
				if (_damp_value_sprint == value)
				{
					return;
				}
				_damp_value_sprint = value;
				PropertySet(this);
			}
		}

		public AnimFeature_ProceduralLean(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
