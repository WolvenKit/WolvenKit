using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliageBrushParams : RedBaseClass
	{
		private CFloat _proximity;
		private CFloat _scale;
		private CFloat _scaleVariation;

		[Ordinal(0)] 
		[RED("Proximity")] 
		public CFloat Proximity
		{
			get => GetProperty(ref _proximity);
			set => SetProperty(ref _proximity, value);
		}

		[Ordinal(1)] 
		[RED("Scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(2)] 
		[RED("ScaleVariation")] 
		public CFloat ScaleVariation
		{
			get => GetProperty(ref _scaleVariation);
			set => SetProperty(ref _scaleVariation, value);
		}

		public worldFoliageBrushParams()
		{
			_proximity = 1.000000F;
			_scale = 1.000000F;
			_scaleVariation = 0.100000F;
		}
	}
}
