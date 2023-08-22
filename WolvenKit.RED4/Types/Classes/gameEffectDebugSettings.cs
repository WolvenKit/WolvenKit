using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectDebugSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("overrideGlobalSettings")] 
		public CBool OverrideGlobalSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public gameEffectDebugSettings()
		{
			Duration = 1.000000F;
			Color = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
