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
			get => GetProperty(ref _sequenceDuration);
			set => SetProperty(ref _sequenceDuration, value);
		}

		[Ordinal(105)] 
		[RED("sequencerMode")] 
		public CEnum<EActionsSequencerMode> SequencerMode
		{
			get => GetProperty(ref _sequencerMode);
			set => SetProperty(ref _sequencerMode, value);
		}

		[Ordinal(106)] 
		[RED("actionTypeToForward")] 
		public SActionTypeForward ActionTypeToForward
		{
			get => GetProperty(ref _actionTypeToForward);
			set => SetProperty(ref _actionTypeToForward, value);
		}

		[Ordinal(107)] 
		[RED("ongoingSequence")] 
		public ActionsSequence OngoingSequence
		{
			get => GetProperty(ref _ongoingSequence);
			set => SetProperty(ref _ongoingSequence, value);
		}

		public ActionsSequencerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
