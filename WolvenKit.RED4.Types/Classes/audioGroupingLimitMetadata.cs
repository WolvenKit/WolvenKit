using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGroupingLimitMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("limit")] 
		public CFloat Limit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
