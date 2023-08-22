using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_PlayerCover : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("cameraPositionMS")] 
		public Vector4 CameraPositionMS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("coverState")] 
		public CInt32 CoverState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("leanAmount")] 
		public CFloat LeanAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("cameraOffsetAmount")] 
		public CFloat CameraOffsetAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("autoCoverActivationFrame")] 
		public CBool AutoCoverActivationFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimFeature_PlayerCover()
		{
			CameraPositionMS = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
