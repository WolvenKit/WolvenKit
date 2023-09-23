using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_CameraBodyOffset : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("lookat_pitch_forward_offset")] 
		public CFloat Lookat_pitch_forward_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("lookat_pitch_forward_down_ratio")] 
		public CFloat Lookat_pitch_forward_down_ratio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("lookat_yaw_left_offset")] 
		public CFloat Lookat_yaw_left_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("lookat_yaw_left_up_offset")] 
		public CFloat Lookat_yaw_left_up_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("lookat_yaw_right_offset")] 
		public CFloat Lookat_yaw_right_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("lookat_yaw_right_up_offset")] 
		public CFloat Lookat_yaw_right_up_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("lookat_yaw_offset_active_angle")] 
		public CFloat Lookat_yaw_offset_active_angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("is_paralax")] 
		public CFloat Is_paralax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("paralax_radius")] 
		public CFloat Paralax_radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("paralax_forward_offset")] 
		public CFloat Paralax_forward_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("lookat_offset_vertical")] 
		public CFloat Lookat_offset_vertical
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_CameraBodyOffset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
