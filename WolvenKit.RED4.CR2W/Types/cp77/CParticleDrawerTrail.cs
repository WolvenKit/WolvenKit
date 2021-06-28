using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerTrail : IParticleDrawer
	{
		private CFloat _texturesPerUnit;
		private CBool _dynamicTexCoords;
		private CInt32 _minSegmentsPer360Degrees;
		private CBool _ribbonize;
		private CFloat _ribbonTesselationDelta;

		[Ordinal(1)] 
		[RED("texturesPerUnit")] 
		public CFloat TexturesPerUnit
		{
			get => GetProperty(ref _texturesPerUnit);
			set => SetProperty(ref _texturesPerUnit, value);
		}

		[Ordinal(2)] 
		[RED("dynamicTexCoords")] 
		public CBool DynamicTexCoords
		{
			get => GetProperty(ref _dynamicTexCoords);
			set => SetProperty(ref _dynamicTexCoords, value);
		}

		[Ordinal(3)] 
		[RED("minSegmentsPer360Degrees")] 
		public CInt32 MinSegmentsPer360Degrees
		{
			get => GetProperty(ref _minSegmentsPer360Degrees);
			set => SetProperty(ref _minSegmentsPer360Degrees, value);
		}

		[Ordinal(4)] 
		[RED("ribbonize")] 
		public CBool Ribbonize
		{
			get => GetProperty(ref _ribbonize);
			set => SetProperty(ref _ribbonize, value);
		}

		[Ordinal(5)] 
		[RED("ribbonTesselationDelta")] 
		public CFloat RibbonTesselationDelta
		{
			get => GetProperty(ref _ribbonTesselationDelta);
			set => SetProperty(ref _ribbonTesselationDelta, value);
		}

		public CParticleDrawerTrail(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
