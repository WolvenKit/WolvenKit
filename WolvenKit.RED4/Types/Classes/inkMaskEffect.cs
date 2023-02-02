using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkMaskEffect : inkIEffect
	{
		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkMaskEffect()
		{
			Opacity = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
