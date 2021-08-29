using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_CameraBodyOffset : animAnimFeature
	{
		private CFloat _lookat_pitch_forward_offset;
		private CFloat _lookat_pitch_forward_down_ratio;
		private CFloat _lookat_yaw_left_offset;
		private CFloat _lookat_yaw_left_up_offset;
		private CFloat _lookat_yaw_right_offset;
		private CFloat _lookat_yaw_right_up_offset;
		private CFloat _lookat_yaw_offset_active_angle;
		private CFloat _is_paralax;
		private CFloat _paralax_radius;
		private CFloat _paralax_forward_offset;
		private CFloat _lookat_offset_vertical;

		[Ordinal(0)] 
		[RED("lookat_pitch_forward_offset")] 
		public CFloat Lookat_pitch_forward_offset
		{
			get => GetProperty(ref _lookat_pitch_forward_offset);
			set => SetProperty(ref _lookat_pitch_forward_offset, value);
		}

		[Ordinal(1)] 
		[RED("lookat_pitch_forward_down_ratio")] 
		public CFloat Lookat_pitch_forward_down_ratio
		{
			get => GetProperty(ref _lookat_pitch_forward_down_ratio);
			set => SetProperty(ref _lookat_pitch_forward_down_ratio, value);
		}

		[Ordinal(2)] 
		[RED("lookat_yaw_left_offset")] 
		public CFloat Lookat_yaw_left_offset
		{
			get => GetProperty(ref _lookat_yaw_left_offset);
			set => SetProperty(ref _lookat_yaw_left_offset, value);
		}

		[Ordinal(3)] 
		[RED("lookat_yaw_left_up_offset")] 
		public CFloat Lookat_yaw_left_up_offset
		{
			get => GetProperty(ref _lookat_yaw_left_up_offset);
			set => SetProperty(ref _lookat_yaw_left_up_offset, value);
		}

		[Ordinal(4)] 
		[RED("lookat_yaw_right_offset")] 
		public CFloat Lookat_yaw_right_offset
		{
			get => GetProperty(ref _lookat_yaw_right_offset);
			set => SetProperty(ref _lookat_yaw_right_offset, value);
		}

		[Ordinal(5)] 
		[RED("lookat_yaw_right_up_offset")] 
		public CFloat Lookat_yaw_right_up_offset
		{
			get => GetProperty(ref _lookat_yaw_right_up_offset);
			set => SetProperty(ref _lookat_yaw_right_up_offset, value);
		}

		[Ordinal(6)] 
		[RED("lookat_yaw_offset_active_angle")] 
		public CFloat Lookat_yaw_offset_active_angle
		{
			get => GetProperty(ref _lookat_yaw_offset_active_angle);
			set => SetProperty(ref _lookat_yaw_offset_active_angle, value);
		}

		[Ordinal(7)] 
		[RED("is_paralax")] 
		public CFloat Is_paralax
		{
			get => GetProperty(ref _is_paralax);
			set => SetProperty(ref _is_paralax, value);
		}

		[Ordinal(8)] 
		[RED("paralax_radius")] 
		public CFloat Paralax_radius
		{
			get => GetProperty(ref _paralax_radius);
			set => SetProperty(ref _paralax_radius, value);
		}

		[Ordinal(9)] 
		[RED("paralax_forward_offset")] 
		public CFloat Paralax_forward_offset
		{
			get => GetProperty(ref _paralax_forward_offset);
			set => SetProperty(ref _paralax_forward_offset, value);
		}

		[Ordinal(10)] 
		[RED("lookat_offset_vertical")] 
		public CFloat Lookat_offset_vertical
		{
			get => GetProperty(ref _lookat_offset_vertical);
			set => SetProperty(ref _lookat_offset_vertical, value);
		}
	}
}
