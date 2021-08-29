using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAdjustableStreamingRangeTarget : gameObject
	{
		private CFloat _minStreamingDistance;

		[Ordinal(40)] 
		[RED("minStreamingDistance")] 
		public CFloat MinStreamingDistance
		{
			get => GetProperty(ref _minStreamingDistance);
			set => SetProperty(ref _minStreamingDistance, value);
		}
	}
}
