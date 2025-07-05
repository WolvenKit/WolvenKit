using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkBlackwallEffect : inkGlitchEffect
	{
		[Ordinal(7)] 
		[RED("scaleX")] 
		public CFloat ScaleX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("scaleY")] 
		public CFloat ScaleY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("layerVisibility")] 
		public CFloat LayerVisibility
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkBlackwallEffect()
		{
			ScaleX = 1.000000F;
			ScaleY = 1.000000F;
			LayerVisibility = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
