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
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(1)] 
		[RED("size_front")] 
		public CFloat Size_front
		{
			get => GetProperty(ref _size_front);
			set => SetProperty(ref _size_front, value);
		}

		[Ordinal(2)] 
		[RED("size_back")] 
		public CFloat Size_back
		{
			get => GetProperty(ref _size_back);
			set => SetProperty(ref _size_back, value);
		}

		[Ordinal(3)] 
		[RED("size_left")] 
		public CFloat Size_left
		{
			get => GetProperty(ref _size_left);
			set => SetProperty(ref _size_left, value);
		}

		[Ordinal(4)] 
		[RED("size_right")] 
		public CFloat Size_right
		{
			get => GetProperty(ref _size_right);
			set => SetProperty(ref _size_right, value);
		}

		[Ordinal(5)] 
		[RED("walk_tilt_coef")] 
		public CFloat Walk_tilt_coef
		{
			get => GetProperty(ref _walk_tilt_coef);
			set => SetProperty(ref _walk_tilt_coef, value);
		}

		[Ordinal(6)] 
		[RED("mass_normalized_coef")] 
		public CFloat Mass_normalized_coef
		{
			get => GetProperty(ref _mass_normalized_coef);
			set => SetProperty(ref _mass_normalized_coef, value);
		}

		[Ordinal(7)] 
		[RED("tilt_angle_on_speed")] 
		public CFloat Tilt_angle_on_speed
		{
			get => GetProperty(ref _tilt_angle_on_speed);
			set => SetProperty(ref _tilt_angle_on_speed, value);
		}

		[Ordinal(8)] 
		[RED("speed_idle_threshold")] 
		public CFloat Speed_idle_threshold
		{
			get => GetProperty(ref _speed_idle_threshold);
			set => SetProperty(ref _speed_idle_threshold, value);
		}

		[Ordinal(9)] 
		[RED("starting_recovery_ballance")] 
		public CFloat Starting_recovery_ballance
		{
			get => GetProperty(ref _starting_recovery_ballance);
			set => SetProperty(ref _starting_recovery_ballance, value);
		}

		[Ordinal(10)] 
		[RED("pseudo_acceleration")] 
		public CFloat Pseudo_acceleration
		{
			get => GetProperty(ref _pseudo_acceleration);
			set => SetProperty(ref _pseudo_acceleration, value);
		}

		[Ordinal(11)] 
		[RED("turn_inertia_damping")] 
		public CFloat Turn_inertia_damping
		{
			get => GetProperty(ref _turn_inertia_damping);
			set => SetProperty(ref _turn_inertia_damping, value);
		}

		[Ordinal(12)] 
		[RED("combat_default_z_offset")] 
		public CFloat Combat_default_z_offset
		{
			get => GetProperty(ref _combat_default_z_offset);
			set => SetProperty(ref _combat_default_z_offset, value);
		}

		public AnimFeature_DroneProcedural(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
