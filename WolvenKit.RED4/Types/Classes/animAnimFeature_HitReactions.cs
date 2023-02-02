using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_HitReactions : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("hitIntensity")] 
		public CFloat HitIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("hitType")] 
		public CInt32 HitType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("hitBodyPart")] 
		public CInt32 HitBodyPart
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimFeature_HitReactions()
		{
			HitDirection = new() { Y = -1.000000F };
			HitIntensity = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
