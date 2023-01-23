using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_ProceduralLean : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("angle_threshold")] 
		public CFloat Angle_threshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("max_turn_angle")] 
		public CFloat Max_turn_angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("hips_shift_side")] 
		public CFloat Hips_shift_side
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("hips_shift_down")] 
		public CFloat Hips_shift_down
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("hips_tilt")] 
		public CFloat Hips_tilt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("hips_turn")] 
		public CFloat Hips_turn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("spine_tilt")] 
		public CFloat Spine_tilt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("spine_turn")] 
		public CFloat Spine_turn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("arms_counter_turn")] 
		public CFloat Arms_counter_turn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("transform_multiplyer")] 
		public CFloat Transform_multiplyer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("damp_value_walk")] 
		public CFloat Damp_value_walk
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("damp_value_sprint")] 
		public CFloat Damp_value_sprint
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_ProceduralLean()
		{
			Angle_threshold = 5.000000F;
			Max_turn_angle = 50.000000F;
			Hips_shift_side = 0.100000F;
			Hips_shift_down = -0.010000F;
			Hips_tilt = -8.000000F;
			Hips_turn = -5.000000F;
			Spine_tilt = -5.000000F;
			Spine_turn = -12.000000F;
			Arms_counter_turn = 10.000000F;
			Transform_multiplyer = 1.000000F;
			Damp_value_walk = 100.000000F;
			Damp_value_sprint = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
