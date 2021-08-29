using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGroupingLimitMetadata : audioAudioMetadata
	{
		private CFloat _limit;

		[Ordinal(1)] 
		[RED("limit")] 
		public CFloat Limit
		{
			get => GetProperty(ref _limit);
			set => SetProperty(ref _limit, value);
		}
	}
}
