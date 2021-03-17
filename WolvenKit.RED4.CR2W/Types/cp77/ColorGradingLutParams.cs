using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ColorGradingLutParams : CVariable
	{
		private rRef<CBitmapTexture> _lUT;
		private CEnum<EColorMappingFunction> _inputMapping;
		private CEnum<EColorMappingFunction> _outputMapping;

		[Ordinal(0)] 
		[RED("LUT")] 
		public rRef<CBitmapTexture> LUT
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

		public ColorGradingLutParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
