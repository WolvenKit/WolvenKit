using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TonemappingModeACES : ITonemappingMode
	{
		[Ordinal(1)] 
		[RED("params")] 
		public STonemappingACESParams Params
		{
			get => GetPropertyValue<STonemappingACESParams>();
			set => SetPropertyValue<STonemappingACESParams>(value);
		}

		public TonemappingModeACES()
		{
			Params = new() { MinStops = -7.000000F, MaxStops = 9.000000F, MidGrayScale = 1.000000F, SurroundGamma = 1.000000F, ToneCurveSaturation = 1.000000F, AdjustWhitePoint = true, DimSurround = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
