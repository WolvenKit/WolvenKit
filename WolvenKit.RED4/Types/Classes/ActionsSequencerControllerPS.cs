using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionsSequencerControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("sequenceDuration")] 
		public CFloat SequenceDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(106)] 
		[RED("sequencerMode")] 
		public CEnum<EActionsSequencerMode> SequencerMode
		{
			get => GetPropertyValue<CEnum<EActionsSequencerMode>>();
			set => SetPropertyValue<CEnum<EActionsSequencerMode>>(value);
		}

		[Ordinal(107)] 
		[RED("actionTypeToForward")] 
		public SActionTypeForward ActionTypeToForward
		{
			get => GetPropertyValue<SActionTypeForward>();
			set => SetPropertyValue<SActionTypeForward>(value);
		}

		[Ordinal(108)] 
		[RED("ongoingSequence")] 
		public ActionsSequence OngoingSequence
		{
			get => GetPropertyValue<ActionsSequence>();
			set => SetPropertyValue<ActionsSequence>(value);
		}

		public ActionsSequencerControllerPS()
		{
			RevealDevicesGrid = false;
			SequenceDuration = 2.000000F;
			ActionTypeToForward = new() { QHack = true };
			OngoingSequence = new() { SequenceInitiator = new(), DelayIDs = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
