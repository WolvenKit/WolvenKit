using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SelectorRevalutionBreak : AIbehaviortaskScript
	{
		private CFloat _reevaluationDuration;
		private CFloat _activationTimeStamp;

		[Ordinal(0)] 
		[RED("reevaluationDuration")] 
		public CFloat ReevaluationDuration
		{
			get => GetProperty(ref _reevaluationDuration);
			set => SetProperty(ref _reevaluationDuration, value);
		}

		[Ordinal(1)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetProperty(ref _activationTimeStamp);
			set => SetProperty(ref _activationTimeStamp, value);
		}
	}
}
