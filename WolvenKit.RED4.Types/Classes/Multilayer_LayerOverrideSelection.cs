using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Multilayer_LayerOverrideSelection : RedBaseClass
	{
		private CName _colorScale;
		private CName _normalStrength;
		private CName _roughLevelsIn;
		private CName _roughLevelsOut;
		private CName _metalLevelsIn;
		private CName _metalLevelsOut;

		[Ordinal(0)] 
		[RED("colorScale")] 
		public CName ColorScale
		{
			get => GetProperty(ref _colorScale);
			set => SetProperty(ref _colorScale, value);
		}

		[Ordinal(1)] 
		[RED("normalStrength")] 
		public CName NormalStrength
		{
			get => GetProperty(ref _normalStrength);
			set => SetProperty(ref _normalStrength, value);
		}

		[Ordinal(2)] 
		[RED("roughLevelsIn")] 
		public CName RoughLevelsIn
		{
			get => GetProperty(ref _roughLevelsIn);
			set => SetProperty(ref _roughLevelsIn, value);
		}

		[Ordinal(3)] 
		[RED("roughLevelsOut")] 
		public CName RoughLevelsOut
		{
			get => GetProperty(ref _roughLevelsOut);
			set => SetProperty(ref _roughLevelsOut, value);
		}

		[Ordinal(4)] 
		[RED("metalLevelsIn")] 
		public CName MetalLevelsIn
		{
			get => GetProperty(ref _metalLevelsIn);
			set => SetProperty(ref _metalLevelsIn, value);
		}

		[Ordinal(5)] 
		[RED("metalLevelsOut")] 
		public CName MetalLevelsOut
		{
			get => GetProperty(ref _metalLevelsOut);
			set => SetProperty(ref _metalLevelsOut, value);
		}
	}
}
