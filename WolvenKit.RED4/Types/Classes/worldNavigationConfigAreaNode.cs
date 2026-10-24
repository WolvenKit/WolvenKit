using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationConfigAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("generateVariantsNavmesh")] 
		public CBool GenerateVariantsNavmesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("detailSamplingDensity")] 
		public CEnum<NavGenSamplingDensity> DetailSamplingDensity
		{
			get => GetPropertyValue<CEnum<NavGenSamplingDensity>>();
			set => SetPropertyValue<CEnum<NavGenSamplingDensity>>(value);
		}

		[Ordinal(6)] 
		[RED("smoothWalkableAreas")] 
		public CBool SmoothWalkableAreas
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("generateCrouchableAreas")] 
		public CBool GenerateCrouchableAreas
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldNavigationConfigAreaNode()
		{
			Color = new CColor { Red = 127, Green = 255, Blue = 127, Alpha = 120 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
