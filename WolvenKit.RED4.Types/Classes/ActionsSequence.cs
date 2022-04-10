using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionsSequence : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sequenceInitiator")] 
		public entEntityID SequenceInitiator
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("maxActionsInSequence")] 
		public CInt32 MaxActionsInSequence
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("actionsTriggeredCount")] 
		public CInt32 ActionsTriggeredCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("delayIDs")] 
		public CArray<gameDelayID> DelayIDs
		{
			get => GetPropertyValue<CArray<gameDelayID>>();
			set => SetPropertyValue<CArray<gameDelayID>>(value);
		}

		public ActionsSequence()
		{
			SequenceInitiator = new();
			DelayIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
