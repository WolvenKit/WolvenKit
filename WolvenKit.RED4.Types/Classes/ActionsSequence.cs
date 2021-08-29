using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionsSequence : RedBaseClass
	{
		private entEntityID _sequenceInitiator;
		private CInt32 _maxActionsInSequence;
		private CInt32 _actionsTriggeredCount;
		private CArray<gameDelayID> _delayIDs;

		[Ordinal(0)] 
		[RED("sequenceInitiator")] 
		public entEntityID SequenceInitiator
		{
			get => GetProperty(ref _sequenceInitiator);
			set => SetProperty(ref _sequenceInitiator, value);
		}

		[Ordinal(1)] 
		[RED("maxActionsInSequence")] 
		public CInt32 MaxActionsInSequence
		{
			get => GetProperty(ref _maxActionsInSequence);
			set => SetProperty(ref _maxActionsInSequence, value);
		}

		[Ordinal(2)] 
		[RED("actionsTriggeredCount")] 
		public CInt32 ActionsTriggeredCount
		{
			get => GetProperty(ref _actionsTriggeredCount);
			set => SetProperty(ref _actionsTriggeredCount, value);
		}

		[Ordinal(3)] 
		[RED("delayIDs")] 
		public CArray<gameDelayID> DelayIDs
		{
			get => GetProperty(ref _delayIDs);
			set => SetProperty(ref _delayIDs, value);
		}
	}
}
