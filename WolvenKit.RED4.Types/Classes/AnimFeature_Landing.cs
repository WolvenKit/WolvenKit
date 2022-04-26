using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_Landing : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("impactSpeed")] 
		public CFloat ImpactSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_Landing()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
