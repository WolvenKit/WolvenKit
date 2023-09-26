using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationConfigAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("generateVariantsNavmesh")] 
		public CBool GenerateVariantsNavmesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("detailSamplingDensity")] 
		public CEnum<NavGenSamplingDensity> DetailSamplingDensity
		{
			get => GetPropertyValue<CEnum<NavGenSamplingDensity>>();
			set => SetPropertyValue<CEnum<NavGenSamplingDensity>>(value);
		}

		[Ordinal(8)] 
		[RED("smoothWalkableAreas")] 
		public CBool SmoothWalkableAreas
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("generateCrouchableAreas")] 
		public CBool GenerateCrouchableAreas
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldNavigationConfigAreaNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
