using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HearStimThreshold : AIbehaviorconditionScript
	{
		private CInt32 _thresholdNumber;

		[Ordinal(0)] 
		[RED("thresholdNumber")] 
		public CInt32 ThresholdNumber
		{
			get => GetProperty(ref _thresholdNumber);
			set => SetProperty(ref _thresholdNumber, value);
		}
	}
}
