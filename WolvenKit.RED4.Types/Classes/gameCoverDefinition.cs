using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCoverDefinition : gameSmartObjectWorkspotDefinition
	{
		private CFloat _overridenCoveringFOVDegrees;
		private CFloat _overridenCoveringVerticalFOVDegrees;
		private CFloat _fovExposureDegrees;
		private CEnum<gameCoverHeight> _overridenHeight;
		private CBool _overrideGeneratedCoverAngles;

		[Ordinal(6)] 
		[RED("overridenCoveringFOVDegrees")] 
		public CFloat OverridenCoveringFOVDegrees
		{
			get => GetProperty(ref _overridenCoveringFOVDegrees);
			set => SetProperty(ref _overridenCoveringFOVDegrees, value);
		}

		[Ordinal(7)] 
		[RED("overridenCoveringVerticalFOVDegrees")] 
		public CFloat OverridenCoveringVerticalFOVDegrees
		{
			get => GetProperty(ref _overridenCoveringVerticalFOVDegrees);
			set => SetProperty(ref _overridenCoveringVerticalFOVDegrees, value);
		}

		[Ordinal(8)] 
		[RED("fovExposureDegrees")] 
		public CFloat FovExposureDegrees
		{
			get => GetProperty(ref _fovExposureDegrees);
			set => SetProperty(ref _fovExposureDegrees, value);
		}

		[Ordinal(9)] 
		[RED("overridenHeight")] 
		public CEnum<gameCoverHeight> OverridenHeight
		{
			get => GetProperty(ref _overridenHeight);
			set => SetProperty(ref _overridenHeight, value);
		}

		[Ordinal(10)] 
		[RED("overrideGeneratedCoverAngles")] 
		public CBool OverrideGeneratedCoverAngles
		{
			get => GetProperty(ref _overrideGeneratedCoverAngles);
			set => SetProperty(ref _overrideGeneratedCoverAngles, value);
		}

		public gameCoverDefinition()
		{
			_overridenCoveringFOVDegrees = 90.000000F;
			_overridenCoveringVerticalFOVDegrees = 90.000000F;
			_fovExposureDegrees = 160.000000F;
		}
	}
}
