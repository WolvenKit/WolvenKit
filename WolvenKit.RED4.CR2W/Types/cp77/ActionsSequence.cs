using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionsSequence : CVariable
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

		public ActionsSequence(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
