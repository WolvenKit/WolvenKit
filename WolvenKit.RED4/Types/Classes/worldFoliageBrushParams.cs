using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliageBrushParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Proximity")] 
		public CFloat Proximity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("Scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("ScaleVariation")] 
		public CFloat ScaleVariation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldFoliageBrushParams()
		{
			Proximity = 1.000000F;
			Scale = 1.000000F;
			ScaleVariation = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
