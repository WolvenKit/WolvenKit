using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_CamberData : animAnimFeatureMarkUnstable
	{
		[Ordinal(0)] 
		[RED("rightFrontCamber")] 
		public CFloat RightFrontCamber
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("leftFrontCamber")] 
		public CFloat LeftFrontCamber
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("rightBackCamber")] 
		public CFloat RightBackCamber
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("leftBackCamber")] 
		public CFloat LeftBackCamber
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("rightFrontCamberOffset")] 
		public Vector4 RightFrontCamberOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("leftFrontCamberOffset")] 
		public Vector4 LeftFrontCamberOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("rightBackCamberOffset")] 
		public Vector4 RightBackCamberOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("leftBackCamberOffset")] 
		public Vector4 LeftBackCamberOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public AnimFeature_CamberData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
