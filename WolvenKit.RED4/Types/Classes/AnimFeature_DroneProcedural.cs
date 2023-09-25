using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_DroneProcedural : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("size_front")] 
		public CFloat Size_front
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("size_back")] 
		public CFloat Size_back
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("size_left")] 
		public CFloat Size_left
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("size_right")] 
		public CFloat Size_right
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("walk_tilt_coef")] 
		public CFloat Walk_tilt_coef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("mass_normalized_coef")] 
		public CFloat Mass_normalized_coef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("tilt_angle_on_speed")] 
		public CFloat Tilt_angle_on_speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("speed_idle_threshold")] 
		public CFloat Speed_idle_threshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("starting_recovery_ballance")] 
		public CFloat Starting_recovery_ballance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("pseudo_acceleration")] 
		public CFloat Pseudo_acceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("turn_inertia_damping")] 
		public CFloat Turn_inertia_damping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("combat_default_z_offset")] 
		public CFloat Combat_default_z_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_DroneProcedural()
		{
			Mass = 100.000000F;
			Size_front = 1.500000F;
			Size_back = -1.500000F;
			Size_left = 1.200000F;
			Size_right = -1.200000F;
			Walk_tilt_coef = 1.330000F;
			Mass_normalized_coef = 2.000000F;
			Tilt_angle_on_speed = 40.000000F;
			Speed_idle_threshold = 0.200000F;
			Starting_recovery_ballance = 0.010000F;
			Pseudo_acceleration = 30.000000F;
			Turn_inertia_damping = 0.750000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
