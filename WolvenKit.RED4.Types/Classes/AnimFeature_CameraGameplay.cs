using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_CameraGameplay : animAnimFeature
	{
		private CFloat _is_forward_offset;
		private CFloat _forward_offset_value;
		private CFloat _upperbody_pitch_weight;
		private CFloat _upperbody_yaw_weight;
		private CFloat _is_pitch_off;
		private CFloat _is_yaw_off;

		[Ordinal(0)] 
		[RED("is_forward_offset")] 
		public CFloat Is_forward_offset
		{
			get => GetProperty(ref _is_forward_offset);
			set => SetProperty(ref _is_forward_offset, value);
		}

		[Ordinal(1)] 
		[RED("forward_offset_value")] 
		public CFloat Forward_offset_value
		{
			get => GetProperty(ref _forward_offset_value);
			set => SetProperty(ref _forward_offset_value, value);
		}

		[Ordinal(2)] 
		[RED("upperbody_pitch_weight")] 
		public CFloat Upperbody_pitch_weight
		{
			get => GetProperty(ref _upperbody_pitch_weight);
			set => SetProperty(ref _upperbody_pitch_weight, value);
		}

		[Ordinal(3)] 
		[RED("upperbody_yaw_weight")] 
		public CFloat Upperbody_yaw_weight
		{
			get => GetProperty(ref _upperbody_yaw_weight);
			set => SetProperty(ref _upperbody_yaw_weight, value);
		}

		[Ordinal(4)] 
		[RED("is_pitch_off")] 
		public CFloat Is_pitch_off
		{
			get => GetProperty(ref _is_pitch_off);
			set => SetProperty(ref _is_pitch_off, value);
		}

		[Ordinal(5)] 
		[RED("is_yaw_off")] 
		public CFloat Is_yaw_off
		{
			get => GetProperty(ref _is_yaw_off);
			set => SetProperty(ref _is_yaw_off, value);
		}
	}
}
