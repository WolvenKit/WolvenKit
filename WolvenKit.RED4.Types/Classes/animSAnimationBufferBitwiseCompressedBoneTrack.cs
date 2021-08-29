using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSAnimationBufferBitwiseCompressedBoneTrack : RedBaseClass
	{
		private animSAnimationBufferBitwiseCompressedData _position;
		private animSAnimationBufferBitwiseCompressedData _orientation;
		private animSAnimationBufferBitwiseCompressedData _scale;

		[Ordinal(0)] 
		[RED("position")] 
		public animSAnimationBufferBitwiseCompressedData Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("orientation")] 
		public animSAnimationBufferBitwiseCompressedData Orientation
		{
			get => GetProperty(ref _orientation);
			set => SetProperty(ref _orientation, value);
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public animSAnimationBufferBitwiseCompressedData Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}
	}
}
