using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FeatureFlagsMask : RedBaseClass
	{
		private CUInt64 _flags;

		[Ordinal(0)] 
		[RED("flags")] 
		public CUInt64 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}
	}
}
