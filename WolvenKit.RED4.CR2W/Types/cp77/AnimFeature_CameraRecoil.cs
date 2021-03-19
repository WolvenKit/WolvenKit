using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraRecoil : animAnimFeature
	{
		private CFloat _backward_offset;
		private CFloat _side_offset;
		private CFloat _tilt_angle;
		private CFloat _yaw_angle;
		private CFloat _pitch_angle;
		private CFloat _translate_transform_speed;
		private CFloat _rotate_transform_speed;
		private CBool _is_offset;

		[Ordinal(0)] 
		[RED("backward_offset")] 
		public CFloat Backward_offset
		{
			get => GetProperty(ref _backward_offset);
			set => SetProperty(ref _backward_offset, value);
		}

		[Ordinal(1)] 
		[RED("side_offset")] 
		public CFloat Side_offset
		{
			get => GetProperty(ref _side_offset);
			set => SetProperty(ref _side_offset, value);
		}

		[Ordinal(2)] 
		[RED("tilt_angle")] 
		public CFloat Tilt_angle
		{
			get => GetProperty(ref _tilt_angle);
			set => SetProperty(ref _tilt_angle, value);
		}

		[Ordinal(3)] 
		[RED("yaw_angle")] 
		public CFloat Yaw_angle
		{
			get => GetProperty(ref _yaw_angle);
			set => SetProperty(ref _yaw_angle, value);
		}

		[Ordinal(4)] 
		[RED("pitch_angle")] 
		public CFloat Pitch_angle
		{
			get => GetProperty(ref _pitch_angle);
			set => SetProperty(ref _pitch_angle, value);
		}

		[Ordinal(5)] 
		[RED("translate_transform_speed")] 
		public CFloat Translate_transform_speed
		{
			get => GetProperty(ref _translate_transform_speed);
			set => SetProperty(ref _translate_transform_speed, value);
		}

		[Ordinal(6)] 
		[RED("rotate_transform_speed")] 
		public CFloat Rotate_transform_speed
		{
			get => GetProperty(ref _rotate_transform_speed);
			set => SetProperty(ref _rotate_transform_speed, value);
		}

		[Ordinal(7)] 
		[RED("is_offset")] 
		public CBool Is_offset
		{
			get => GetProperty(ref _is_offset);
			set => SetProperty(ref _is_offset, value);
		}

		public AnimFeature_CameraRecoil(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
