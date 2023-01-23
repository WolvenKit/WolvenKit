using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RenderSettingFactors : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("resolutionAberrationScale")] 
		public CLegacySingleChannelCurve<CFloat> ResolutionAberrationScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("resolutionAberrationDispersal")] 
		public CLegacySingleChannelCurve<CFloat> ResolutionAberrationDispersal
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("resolutionFilmGrainScale")] 
		public CLegacySingleChannelCurve<CFloat> ResolutionFilmGrainScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("resolutionFilmGrainStrength")] 
		public CLegacySingleChannelCurve<CFloat> ResolutionFilmGrainStrength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public RenderSettingFactors()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
