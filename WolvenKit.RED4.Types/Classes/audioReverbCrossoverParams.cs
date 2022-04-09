using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioReverbCrossoverParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("dist")] 
		public CFloat Dist
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("fade")] 
		public CFloat Fade
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioReverbCrossoverParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
