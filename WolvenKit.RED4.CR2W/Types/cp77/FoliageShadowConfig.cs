using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FoliageShadowConfig : CVariable
	{
		private CFloat _foliageShadowCascadeGradient;
		private CFloat _foliageShadowCascadeFilterScale;
		private CFloat _foliageShadowCascadeGradientDistanceRange;

		[Ordinal(0)] 
		[RED("foliageShadowCascadeGradient")] 
		public CFloat FoliageShadowCascadeGradient
		{
			get => GetProperty(ref _foliageShadowCascadeGradient);
			set => SetProperty(ref _foliageShadowCascadeGradient, value);
		}

		[Ordinal(1)] 
		[RED("foliageShadowCascadeFilterScale")] 
		public CFloat FoliageShadowCascadeFilterScale
		{
			get => GetProperty(ref _foliageShadowCascadeFilterScale);
			set => SetProperty(ref _foliageShadowCascadeFilterScale, value);
		}

		[Ordinal(2)] 
		[RED("foliageShadowCascadeGradientDistanceRange")] 
		public CFloat FoliageShadowCascadeGradientDistanceRange
		{
			get => GetProperty(ref _foliageShadowCascadeGradientDistanceRange);
			set => SetProperty(ref _foliageShadowCascadeGradientDistanceRange, value);
		}

		public FoliageShadowConfig(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
