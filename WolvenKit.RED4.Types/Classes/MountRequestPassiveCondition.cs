using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MountRequestPassiveCondition : AIbehaviorexpressionScript
	{
		private CBool _unmountRequest;
		private CBool _acceptInstant;
		private CBool _acceptNotInstant;
		private CBool _acceptForcedTransition;
		private CBool _succeedOnMissingMountedEntity;
		private CUInt32 _callbackId;
		private CUInt32 _highLevelStateCallbackId;

		[Ordinal(0)] 
		[RED("unmountRequest")] 
		public CBool UnmountRequest
		{
			get => GetProperty(ref _unmountRequest);
			set => SetProperty(ref _unmountRequest, value);
		}

		[Ordinal(1)] 
		[RED("acceptInstant")] 
		public CBool AcceptInstant
		{
			get => GetProperty(ref _acceptInstant);
			set => SetProperty(ref _acceptInstant, value);
		}

		[Ordinal(2)] 
		[RED("acceptNotInstant")] 
		public CBool AcceptNotInstant
		{
			get => GetProperty(ref _acceptNotInstant);
			set => SetProperty(ref _acceptNotInstant, value);
		}

		[Ordinal(3)] 
		[RED("acceptForcedTransition")] 
		public CBool AcceptForcedTransition
		{
			get => GetProperty(ref _acceptForcedTransition);
			set => SetProperty(ref _acceptForcedTransition, value);
		}

		[Ordinal(4)] 
		[RED("succeedOnMissingMountedEntity")] 
		public CBool SucceedOnMissingMountedEntity
		{
			get => GetProperty(ref _succeedOnMissingMountedEntity);
			set => SetProperty(ref _succeedOnMissingMountedEntity, value);
		}

		[Ordinal(5)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get => GetProperty(ref _callbackId);
			set => SetProperty(ref _callbackId, value);
		}

		[Ordinal(6)] 
		[RED("highLevelStateCallbackId")] 
		public CUInt32 HighLevelStateCallbackId
		{
			get => GetProperty(ref _highLevelStateCallbackId);
			set => SetProperty(ref _highLevelStateCallbackId, value);
		}

		public MountRequestPassiveCondition()
		{
			_acceptInstant = true;
			_acceptNotInstant = true;
		}
	}
}
