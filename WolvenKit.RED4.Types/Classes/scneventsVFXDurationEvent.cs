using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsVFXDurationEvent : scnSceneEvent
	{
		private scnEffectEntry _effectEntry;
		private CEnum<scneventsVFXActionType> _startAction;
		private CEnum<scneventsVFXActionType> _endAction;
		private CUInt32 _sequenceShift;
		private scnPerformerId _performerId;
		private NodeRef _nodeRef;
		private CBool _muteSound;

		[Ordinal(6)] 
		[RED("effectEntry")] 
		public scnEffectEntry EffectEntry
		{
			get => GetProperty(ref _effectEntry);
			set => SetProperty(ref _effectEntry, value);
		}

		[Ordinal(7)] 
		[RED("startAction")] 
		public CEnum<scneventsVFXActionType> StartAction
		{
			get => GetProperty(ref _startAction);
			set => SetProperty(ref _startAction, value);
		}

		[Ordinal(8)] 
		[RED("endAction")] 
		public CEnum<scneventsVFXActionType> EndAction
		{
			get => GetProperty(ref _endAction);
			set => SetProperty(ref _endAction, value);
		}

		[Ordinal(9)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get => GetProperty(ref _sequenceShift);
			set => SetProperty(ref _sequenceShift, value);
		}

		[Ordinal(10)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(11)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(12)] 
		[RED("muteSound")] 
		public CBool MuteSound
		{
			get => GetProperty(ref _muteSound);
			set => SetProperty(ref _muteSound, value);
		}
	}
}
