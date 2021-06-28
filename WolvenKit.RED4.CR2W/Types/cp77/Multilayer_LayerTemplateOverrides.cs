using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplateOverrides : CVariable
	{
		private CArray<Multilayer_LayerTemplateOverridesColor> _colorScale;
		private CArray<Multilayer_LayerTemplateOverridesLevels> _roughLevelsIn;
		private CArray<Multilayer_LayerTemplateOverridesLevels> _roughLevelsOut;
		private CArray<Multilayer_LayerTemplateOverridesLevels> _metalLevelsIn;
		private CArray<Multilayer_LayerTemplateOverridesLevels> _metalLevelsOut;
		private CArray<Multilayer_LayerTemplateOverridesNormalStrength> _normalStrength;

		[Ordinal(0)] 
		[RED("colorScale")] 
		public CArray<Multilayer_LayerTemplateOverridesColor> ColorScale
		{
			get => GetProperty(ref _colorScale);
			set => SetProperty(ref _colorScale, value);
		}

		[Ordinal(1)] 
		[RED("roughLevelsIn")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsIn
		{
			get => GetProperty(ref _roughLevelsIn);
			set => SetProperty(ref _roughLevelsIn, value);
		}

		[Ordinal(2)] 
		[RED("roughLevelsOut")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsOut
		{
			get => GetProperty(ref _roughLevelsOut);
			set => SetProperty(ref _roughLevelsOut, value);
		}

		[Ordinal(3)] 
		[RED("metalLevelsIn")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsIn
		{
			get => GetProperty(ref _metalLevelsIn);
			set => SetProperty(ref _metalLevelsIn, value);
		}

		[Ordinal(4)] 
		[RED("metalLevelsOut")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsOut
		{
			get => GetProperty(ref _metalLevelsOut);
			set => SetProperty(ref _metalLevelsOut, value);
		}

		[Ordinal(5)] 
		[RED("normalStrength")] 
		public CArray<Multilayer_LayerTemplateOverridesNormalStrength> NormalStrength
		{
			get => GetProperty(ref _normalStrength);
			set => SetProperty(ref _normalStrength, value);
		}

		public Multilayer_LayerTemplateOverrides(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
