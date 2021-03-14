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
			get
			{
				if (_sequenceInitiator == null)
				{
					_sequenceInitiator = (entEntityID) CR2WTypeManager.Create("entEntityID", "sequenceInitiator", cr2w, this);
				}
				return _sequenceInitiator;
			}
			set
			{
				if (_sequenceInitiator == value)
				{
					return;
				}
				_sequenceInitiator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxActionsInSequence")] 
		public CInt32 MaxActionsInSequence
		{
			get
			{
				if (_maxActionsInSequence == null)
				{
					_maxActionsInSequence = (CInt32) CR2WTypeManager.Create("Int32", "maxActionsInSequence", cr2w, this);
				}
				return _maxActionsInSequence;
			}
			set
			{
				if (_maxActionsInSequence == value)
				{
					return;
				}
				_maxActionsInSequence = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("actionsTriggeredCount")] 
		public CInt32 ActionsTriggeredCount
		{
			get
			{
				if (_actionsTriggeredCount == null)
				{
					_actionsTriggeredCount = (CInt32) CR2WTypeManager.Create("Int32", "actionsTriggeredCount", cr2w, this);
				}
				return _actionsTriggeredCount;
			}
			set
			{
				if (_actionsTriggeredCount == value)
				{
					return;
				}
				_actionsTriggeredCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("delayIDs")] 
		public CArray<gameDelayID> DelayIDs
		{
			get
			{
				if (_delayIDs == null)
				{
					_delayIDs = (CArray<gameDelayID>) CR2WTypeManager.Create("array:gameDelayID", "delayIDs", cr2w, this);
				}
				return _delayIDs;
			}
			set
			{
				if (_delayIDs == value)
				{
					return;
				}
				_delayIDs = value;
				PropertySet(this);
			}
		}

		public ActionsSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
