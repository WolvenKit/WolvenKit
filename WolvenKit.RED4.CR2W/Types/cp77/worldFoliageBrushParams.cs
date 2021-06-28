using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBrushParams : CVariable
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

		public worldFoliageBrushParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
