using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MaterialTechnique : RedBaseClass
	{
		private CArray<MaterialPass> _passes;
		private FeatureFlagsMask _featureFlagsEnabledMask;
		private CUInt32 _streamsToBind;

		[Ordinal(0)] 
		[RED("passes")] 
		public CArray<MaterialPass> Passes
		{
			get => GetProperty(ref _passes);
			set => SetProperty(ref _passes, value);
		}

		[Ordinal(1)] 
		[RED("featureFlagsEnabledMask")] 
		public FeatureFlagsMask FeatureFlagsEnabledMask
		{
			get => GetProperty(ref _featureFlagsEnabledMask);
			set => SetProperty(ref _featureFlagsEnabledMask, value);
		}

		[Ordinal(2)] 
		[RED("streamsToBind")] 
		public CUInt32 StreamsToBind
		{
			get => GetProperty(ref _streamsToBind);
			set => SetProperty(ref _streamsToBind, value);
		}
	}
}
