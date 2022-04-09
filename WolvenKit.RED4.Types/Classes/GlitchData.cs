using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlitchData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EGlitchState> State
		{
			get => GetPropertyValue<CEnum<EGlitchState>>();
			set => SetPropertyValue<CEnum<EGlitchState>>(value);
		}

		public GlitchData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
