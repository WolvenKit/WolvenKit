using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FeatureFlagsMask : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("flags")] 
		public CUInt64 Flags
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public FeatureFlagsMask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
