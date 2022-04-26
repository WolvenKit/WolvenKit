using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioWaitTimeASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] 
		[RED("timeToWait")] 
		public CFloat TimeToWait
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioWaitTimeASTCD()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
