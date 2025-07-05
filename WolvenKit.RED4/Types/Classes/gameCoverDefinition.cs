using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCoverDefinition : gameSmartObjectWorkspotDefinition
	{
		[Ordinal(6)] 
		[RED("overridenCoveringFOVDegrees")] 
		public CFloat OverridenCoveringFOVDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("overridenCoveringVerticalFOVDegrees")] 
		public CFloat OverridenCoveringVerticalFOVDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("fovExposureDegrees")] 
		public CFloat FovExposureDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("overridenHeight")] 
		public CEnum<gameCoverHeight> OverridenHeight
		{
			get => GetPropertyValue<CEnum<gameCoverHeight>>();
			set => SetPropertyValue<CEnum<gameCoverHeight>>(value);
		}

		[Ordinal(10)] 
		[RED("overrideGeneratedCoverAngles")] 
		public CBool OverrideGeneratedCoverAngles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameCoverDefinition()
		{
			OverridenCoveringFOVDegrees = 90.000000F;
			OverridenCoveringVerticalFOVDegrees = 90.000000F;
			FovExposureDegrees = 160.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
