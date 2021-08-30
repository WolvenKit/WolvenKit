using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionsSequencerControllerPS : MasterControllerPS
	{
		private CFloat _sequenceDuration;
		private CEnum<EActionsSequencerMode> _sequencerMode;
		private SActionTypeForward _actionTypeToForward;
		private ActionsSequence _ongoingSequence;

		[Ordinal(105)] 
		[RED("sequenceDuration")] 
		public CFloat SequenceDuration
		{
			get => GetProperty(ref _sequenceDuration);
			set => SetProperty(ref _sequenceDuration, value);
		}

		[Ordinal(106)] 
		[RED("sequencerMode")] 
		public CEnum<EActionsSequencerMode> SequencerMode
		{
			get => GetProperty(ref _sequencerMode);
			set => SetProperty(ref _sequencerMode, value);
		}

		[Ordinal(107)] 
		[RED("actionTypeToForward")] 
		public SActionTypeForward ActionTypeToForward
		{
			get => GetProperty(ref _actionTypeToForward);
			set => SetProperty(ref _actionTypeToForward, value);
		}

		[Ordinal(108)] 
		[RED("ongoingSequence")] 
		public ActionsSequence OngoingSequence
		{
			get => GetProperty(ref _ongoingSequence);
			set => SetProperty(ref _ongoingSequence, value);
		}

		public ActionsSequencerControllerPS()
		{
			_sequenceDuration = 2.000000F;
		}
	}
}
