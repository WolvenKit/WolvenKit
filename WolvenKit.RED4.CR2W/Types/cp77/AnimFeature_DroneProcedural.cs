using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DroneProcedural : animAnimFeature
	{
		private CFloat _mass;
		private CFloat _size_front;
		private CFloat _size_back;
		private CFloat _size_left;
		private CFloat _size_right;
		private CFloat _walk_tilt_coef;
		private CFloat _mass_normalized_coef;
		private CFloat _tilt_angle_on_speed;
		private CFloat _speed_idle_threshold;
		private CFloat _starting_recovery_ballance;
		private CFloat _pseudo_acceleration;
		private CFloat _turn_inertia_damping;
		private CFloat _combat_default_z_offset;

		[Ordinal(0)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get
			{
				if (_mass == null)
				{
					_mass = (CFloat) CR2WTypeManager.Create("Float", "mass", cr2w, this);
				}
				return _mass;
			}
			set
			{
				if (_mass == value)
				{
					return;
				}
				_mass = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("size_front")] 
		public CFloat Size_front
		{
			get
			{
				if (_size_front == null)
				{
					_size_front = (CFloat) CR2WTypeManager.Create("Float", "size_front", cr2w, this);
				}
				return _size_front;
			}
			set
			{
				if (_size_front == value)
				{
					return;
				}
				_size_front = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("size_back")] 
		public CFloat Size_back
		{
			get
			{
				if (_size_back == null)
				{
					_size_back = (CFloat) CR2WTypeManager.Create("Float", "size_back", cr2w, this);
				}
				return _size_back;
			}
			set
			{
				if (_size_back == value)
				{
					return;
				}
				_size_back = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("size_left")] 
		public CFloat Size_left
		{
			get
			{
				if (_size_left == null)
				{
					_size_left = (CFloat) CR2WTypeManager.Create("Float", "size_left", cr2w, this);
				}
				return _size_left;
			}
			set
			{
				if (_size_left == value)
				{
					return;
				}
				_size_left = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("size_right")] 
		public CFloat Size_right
		{
			get
			{
				if (_size_right == null)
				{
					_size_right = (CFloat) CR2WTypeManager.Create("Float", "size_right", cr2w, this);
				}
				return _size_right;
			}
			set
			{
				if (_size_right == value)
				{
					return;
				}
				_size_right = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("walk_tilt_coef")] 
		public CFloat Walk_tilt_coef
		{
			get
			{
				if (_walk_tilt_coef == null)
				{
					_walk_tilt_coef = (CFloat) CR2WTypeManager.Create("Float", "walk_tilt_coef", cr2w, this);
				}
				return _walk_tilt_coef;
			}
			set
			{
				if (_walk_tilt_coef == value)
				{
					return;
				}
				_walk_tilt_coef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("mass_normalized_coef")] 
		public CFloat Mass_normalized_coef
		{
			get
			{
				if (_mass_normalized_coef == null)
				{
					_mass_normalized_coef = (CFloat) CR2WTypeManager.Create("Float", "mass_normalized_coef", cr2w, this);
				}
				return _mass_normalized_coef;
			}
			set
			{
				if (_mass_normalized_coef == value)
				{
					return;
				}
				_mass_normalized_coef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tilt_angle_on_speed")] 
		public CFloat Tilt_angle_on_speed
		{
			get
			{
				if (_tilt_angle_on_speed == null)
				{
					_tilt_angle_on_speed = (CFloat) CR2WTypeManager.Create("Float", "tilt_angle_on_speed", cr2w, this);
				}
				return _tilt_angle_on_speed;
			}
			set
			{
				if (_tilt_angle_on_speed == value)
				{
					return;
				}
				_tilt_angle_on_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("speed_idle_threshold")] 
		public CFloat Speed_idle_threshold
		{
			get
			{
				if (_speed_idle_threshold == null)
				{
					_speed_idle_threshold = (CFloat) CR2WTypeManager.Create("Float", "speed_idle_threshold", cr2w, this);
				}
				return _speed_idle_threshold;
			}
			set
			{
				if (_speed_idle_threshold == value)
				{
					return;
				}
				_speed_idle_threshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("starting_recovery_ballance")] 
		public CFloat Starting_recovery_ballance
		{
			get
			{
				if (_starting_recovery_ballance == null)
				{
					_starting_recovery_ballance = (CFloat) CR2WTypeManager.Create("Float", "starting_recovery_ballance", cr2w, this);
				}
				return _starting_recovery_ballance;
			}
			set
			{
				if (_starting_recovery_ballance == value)
				{
					return;
				}
				_starting_recovery_ballance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("pseudo_acceleration")] 
		public CFloat Pseudo_acceleration
		{
			get
			{
				if (_pseudo_acceleration == null)
				{
					_pseudo_acceleration = (CFloat) CR2WTypeManager.Create("Float", "pseudo_acceleration", cr2w, this);
				}
				return _pseudo_acceleration;
			}
			set
			{
				if (_pseudo_acceleration == value)
				{
					return;
				}
				_pseudo_acceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("turn_inertia_damping")] 
		public CFloat Turn_inertia_damping
		{
			get
			{
				if (_turn_inertia_damping == null)
				{
					_turn_inertia_damping = (CFloat) CR2WTypeManager.Create("Float", "turn_inertia_damping", cr2w, this);
				}
				return _turn_inertia_damping;
			}
			set
			{
				if (_turn_inertia_damping == value)
				{
					return;
				}
				_turn_inertia_damping = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("combat_default_z_offset")] 
		public CFloat Combat_default_z_offset
		{
			get
			{
				if (_combat_default_z_offset == null)
				{
					_combat_default_z_offset = (CFloat) CR2WTypeManager.Create("Float", "combat_default_z_offset", cr2w, this);
				}
				return _combat_default_z_offset;
			}
			set
			{
				if (_combat_default_z_offset == value)
				{
					return;
				}
				_combat_default_z_offset = value;
				PropertySet(this);
			}
		}

		public AnimFeature_DroneProcedural(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
