using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IncrimentStimThreshold : AIbehaviortaskScript
	{
		private CFloat _thresholdTimeout;

		[Ordinal(0)] 
		[RED("thresholdTimeout")] 
		public CFloat ThresholdTimeout
		{
			get => GetProperty(ref _thresholdTimeout);
			set => SetProperty(ref _thresholdTimeout, value);
		}
	}
}
