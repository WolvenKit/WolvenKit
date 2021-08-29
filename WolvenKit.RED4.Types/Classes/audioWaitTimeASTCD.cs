using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioWaitTimeASTCD : audioAudioStateTransitionConditionData
	{
		private CFloat _timeToWait;

		[Ordinal(1)] 
		[RED("timeToWait")] 
		public CFloat TimeToWait
		{
			get => GetProperty(ref _timeToWait);
			set => SetProperty(ref _timeToWait, value);
		}
	}
}
