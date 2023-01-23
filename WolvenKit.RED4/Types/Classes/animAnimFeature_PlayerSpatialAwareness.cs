using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_PlayerSpatialAwareness : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("leftClosestVector")] 
		public Vector4 LeftClosestVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("rightClosestVector")] 
		public Vector4 RightClosestVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("upHitPosition")] 
		public Vector4 UpHitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("forwardDistance")] 
		public CFloat ForwardDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimFeature_PlayerSpatialAwareness()
		{
			LeftClosestVector = new();
			RightClosestVector = new();
			UpHitPosition = new();
			ForwardDistance = 340282346638528859811704183484516925440.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
