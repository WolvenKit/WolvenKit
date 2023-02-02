using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VignetteAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("vignetteEnabled")] 
		public CBool VignetteEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("vignetteRadius")] 
		public CFloat VignetteRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("vignetteExp")] 
		public CFloat VignetteExp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("vignetteColor")] 
		public CColor VignetteColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public VignetteAreaSettings()
		{
			Enable = true;
			VignetteRadius = 0.500000F;
			VignetteExp = 2.000000F;
			VignetteColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
