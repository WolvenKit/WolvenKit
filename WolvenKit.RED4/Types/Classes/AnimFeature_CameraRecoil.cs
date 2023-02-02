using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_CameraRecoil : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("backward_offset")] 
		public CFloat Backward_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("side_offset")] 
		public CFloat Side_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("tilt_angle")] 
		public CFloat Tilt_angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("yaw_angle")] 
		public CFloat Yaw_angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("pitch_angle")] 
		public CFloat Pitch_angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("translate_transform_speed")] 
		public CFloat Translate_transform_speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("rotate_transform_speed")] 
		public CFloat Rotate_transform_speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("is_offset")] 
		public CBool Is_offset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_CameraRecoil()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
