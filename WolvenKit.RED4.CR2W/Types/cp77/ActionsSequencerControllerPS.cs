using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionsSequencerControllerPS : MasterControllerPS
	{
		private CFloat _sequenceDuration;
		private CEnum<EActionsSequencerMode> _sequencerMode;
		private SActionTypeForward _actionTypeToForward;
		private ActionsSequence _ongoingSequence;

		[Ordinal(104)] 
		[RED("sequenceDuration")] 
		public CFloat SequenceDuration
		{
			get
			{
				if (_sequenceDuration == null)
				{
					_sequenceDuration = (CFloat) CR2WTypeManager.Create("Float", "sequenceDuration", cr2w, this);
				}
				return _sequenceDuration;
			}
			set
			{
				if (_sequenceDuration == value)
				{
					return;
				}
				_sequenceDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("sequencerMode")] 
		public CEnum<EActionsSequencerMode> SequencerMode
		{
			get
			{
				if (_sequencerMode == null)
				{
					_sequencerMode = (CEnum<EActionsSequencerMode>) CR2WTypeManager.Create("EActionsSequencerMode", "sequencerMode", cr2w, this);
				}
				return _sequencerMode;
			}
			set
			{
				if (_sequencerMode == value)
				{
					return;
				}
				_sequencerMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("actionTypeToForward")] 
		public SActionTypeForward ActionTypeToForward
		{
			get
			{
				if (_actionTypeToForward == null)
				{
					_actionTypeToForward = (SActionTypeForward) CR2WTypeManager.Create("SActionTypeForward", "actionTypeToForward", cr2w, this);
				}
				return _actionTypeToForward;
			}
			set
			{
				if (_actionTypeToForward == value)
				{
					return;
				}
				_actionTypeToForward = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("ongoingSequence")] 
		public ActionsSequence OngoingSequence
		{
			get
			{
				if (_ongoingSequence == null)
				{
					_ongoingSequence = (ActionsSequence) CR2WTypeManager.Create("ActionsSequence", "ongoingSequence", cr2w, this);
				}
				return _ongoingSequence;
			}
			set
			{
				if (_ongoingSequence == value)
				{
					return;
				}
				_ongoingSequence = value;
				PropertySet(this);
			}
		}

		public ActionsSequencerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
