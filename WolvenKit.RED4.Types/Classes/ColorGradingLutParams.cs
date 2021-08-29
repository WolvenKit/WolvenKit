using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ColorGradingLutParams : RedBaseClass
	{
		private CResourceReference<CBitmapTexture> _lUT;
		private CEnum<EColorMappingFunction> _inputMapping;
		private CEnum<EColorMappingFunction> _outputMapping;

		[Ordinal(0)] 
		[RED("LUT")] 
		public CResourceReference<CBitmapTexture> LUT
		{
			get => GetProperty(ref _lUT);
			set => SetProperty(ref _lUT, value);
		}

		[Ordinal(1)] 
		[RED("inputMapping")] 
		public CEnum<EColorMappingFunction> InputMapping
		{
			get => GetProperty(ref _inputMapping);
			set => SetProperty(ref _inputMapping, value);
		}

		[Ordinal(2)] 
		[RED("outputMapping")] 
		public CEnum<EColorMappingFunction> OutputMapping
		{
			get => GetProperty(ref _outputMapping);
			set => SetProperty(ref _outputMapping, value);
		}
	}
}
