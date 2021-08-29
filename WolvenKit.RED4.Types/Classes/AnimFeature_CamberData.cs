using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_CamberData : animAnimFeatureMarkUnstable
	{
		private CFloat _rightFrontCamber;
		private CFloat _leftFrontCamber;
		private CFloat _rightBackCamber;
		private CFloat _leftBackCamber;
		private Vector4 _rightFrontCamberOffset;
		private Vector4 _leftFrontCamberOffset;
		private Vector4 _rightBackCamberOffset;
		private Vector4 _leftBackCamberOffset;

		[Ordinal(0)] 
		[RED("rightFrontCamber")] 
		public CFloat RightFrontCamber
		{
			get => GetProperty(ref _rightFrontCamber);
			set => SetProperty(ref _rightFrontCamber, value);
		}

		[Ordinal(1)] 
		[RED("leftFrontCamber")] 
		public CFloat LeftFrontCamber
		{
			get => GetProperty(ref _leftFrontCamber);
			set => SetProperty(ref _leftFrontCamber, value);
		}

		[Ordinal(2)] 
		[RED("rightBackCamber")] 
		public CFloat RightBackCamber
		{
			get => GetProperty(ref _rightBackCamber);
			set => SetProperty(ref _rightBackCamber, value);
		}

		[Ordinal(3)] 
		[RED("leftBackCamber")] 
		public CFloat LeftBackCamber
		{
			get => GetProperty(ref _leftBackCamber);
			set => SetProperty(ref _leftBackCamber, value);
		}

		[Ordinal(4)] 
		[RED("rightFrontCamberOffset")] 
		public Vector4 RightFrontCamberOffset
		{
			get => GetProperty(ref _rightFrontCamberOffset);
			set => SetProperty(ref _rightFrontCamberOffset, value);
		}

		[Ordinal(5)] 
		[RED("leftFrontCamberOffset")] 
		public Vector4 LeftFrontCamberOffset
		{
			get => GetProperty(ref _leftFrontCamberOffset);
			set => SetProperty(ref _leftFrontCamberOffset, value);
		}

		[Ordinal(6)] 
		[RED("rightBackCamberOffset")] 
		public Vector4 RightBackCamberOffset
		{
			get => GetProperty(ref _rightBackCamberOffset);
			set => SetProperty(ref _rightBackCamberOffset, value);
		}

		[Ordinal(7)] 
		[RED("leftBackCamberOffset")] 
		public Vector4 LeftBackCamberOffset
		{
			get => GetProperty(ref _leftBackCamberOffset);
			set => SetProperty(ref _leftBackCamberOffset, value);
		}
	}
}
