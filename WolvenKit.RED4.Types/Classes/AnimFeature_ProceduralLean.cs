using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_ProceduralLean : animAnimFeature
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
			get => GetProperty(ref _angle_threshold);
			set => SetProperty(ref _angle_threshold, value);
		}

		[Ordinal(1)] 
		[RED("max_turn_angle")] 
		public CFloat Max_turn_angle
		{
			get => GetProperty(ref _max_turn_angle);
			set => SetProperty(ref _max_turn_angle, value);
		}

		[Ordinal(2)] 
		[RED("hips_shift_side")] 
		public CFloat Hips_shift_side
		{
			get => GetProperty(ref _hips_shift_side);
			set => SetProperty(ref _hips_shift_side, value);
		}

		[Ordinal(3)] 
		[RED("hips_shift_down")] 
		public CFloat Hips_shift_down
		{
			get => GetProperty(ref _hips_shift_down);
			set => SetProperty(ref _hips_shift_down, value);
		}

		[Ordinal(4)] 
		[RED("hips_tilt")] 
		public CFloat Hips_tilt
		{
			get => GetProperty(ref _hips_tilt);
			set => SetProperty(ref _hips_tilt, value);
		}

		[Ordinal(5)] 
		[RED("hips_turn")] 
		public CFloat Hips_turn
		{
			get => GetProperty(ref _hips_turn);
			set => SetProperty(ref _hips_turn, value);
		}

		[Ordinal(6)] 
		[RED("spine_tilt")] 
		public CFloat Spine_tilt
		{
			get => GetProperty(ref _spine_tilt);
			set => SetProperty(ref _spine_tilt, value);
		}

		[Ordinal(7)] 
		[RED("spine_turn")] 
		public CFloat Spine_turn
		{
			get => GetProperty(ref _spine_turn);
			set => SetProperty(ref _spine_turn, value);
		}

		[Ordinal(8)] 
		[RED("arms_counter_turn")] 
		public CFloat Arms_counter_turn
		{
			get => GetProperty(ref _arms_counter_turn);
			set => SetProperty(ref _arms_counter_turn, value);
		}

		[Ordinal(9)] 
		[RED("transform_multiplyer")] 
		public CFloat Transform_multiplyer
		{
			get => GetProperty(ref _transform_multiplyer);
			set => SetProperty(ref _transform_multiplyer, value);
		}

		[Ordinal(10)] 
		[RED("damp_value_walk")] 
		public CFloat Damp_value_walk
		{
			get => GetProperty(ref _damp_value_walk);
			set => SetProperty(ref _damp_value_walk, value);
		}

		[Ordinal(11)] 
		[RED("damp_value_sprint")] 
		public CFloat Damp_value_sprint
		{
			get => GetProperty(ref _damp_value_sprint);
			set => SetProperty(ref _damp_value_sprint, value);
		}

		public AnimFeature_ProceduralLean()
		{
			_angle_threshold = 5.000000F;
			_max_turn_angle = 50.000000F;
			_hips_shift_side = 0.100000F;
			_hips_shift_down = -0.010000F;
			_hips_tilt = -8.000000F;
			_hips_turn = -5.000000F;
			_spine_tilt = -5.000000F;
			_spine_turn = -12.000000F;
			_arms_counter_turn = 10.000000F;
			_transform_multiplyer = 1.000000F;
			_damp_value_walk = 100.000000F;
			_damp_value_sprint = 100.000000F;
		}
	}
}
