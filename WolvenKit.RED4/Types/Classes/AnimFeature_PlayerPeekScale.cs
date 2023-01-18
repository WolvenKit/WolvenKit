using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_PlayerPeekScale : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("peekScale")] 
		public CFloat PeekScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_PlayerPeekScale()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
