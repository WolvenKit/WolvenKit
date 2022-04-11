using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MaterialTechnique : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("passes")] 
		public CArray<MaterialPass> Passes
		{
			get => GetPropertyValue<CArray<MaterialPass>>();
			set => SetPropertyValue<CArray<MaterialPass>>(value);
		}

		[Ordinal(1)] 
		[RED("featureFlagsEnabledMask")] 
		public FeatureFlagsMask FeatureFlagsEnabledMask
		{
			get => GetPropertyValue<FeatureFlagsMask>();
			set => SetPropertyValue<FeatureFlagsMask>(value);
		}

		[Ordinal(2)] 
		[RED("streamsToBind")] 
		public CUInt32 StreamsToBind
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public MaterialTechnique()
		{
			Passes = new();
			FeatureFlagsEnabledMask = new();
		}
	}
}
