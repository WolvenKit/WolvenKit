using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionDescription : ISerializable
	{
		private CUInt32 _targetStateIndex;
		private CHandle<animIAnimStateTransitionCondition> _condition;
		private CBool _isEnabled;
		private CHandle<animIAnimStateTransitionInterpolator> _interpolator;
		private CFloat _duration;
		private CInt32 _priority;
		private CHandle<animISyncMethod> _syncMethod;
		private CBool _isForcedToTrue;
		private CBool _supportBlendFromPose;
		private CBool _canRequestInertialization;
		private CName _animFeatureName;
		private CResourceReference<animActionAnimDatabase> _actionAnimDatabaseRef;
		private CBool _isOutTransitionFromAction;

		[Ordinal(0)] 
		[RED("targetStateIndex")] 
		public CUInt32 TargetStateIndex
		{
			get => GetProperty(ref _targetStateIndex);
			set => SetProperty(ref _targetStateIndex, value);
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<animIAnimStateTransitionCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(3)] 
		[RED("interpolator")] 
		public CHandle<animIAnimStateTransitionInterpolator> Interpolator
		{
			get => GetProperty(ref _interpolator);
			set => SetProperty(ref _interpolator, value);
		}

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(5)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(6)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetProperty(ref _syncMethod);
			set => SetProperty(ref _syncMethod, value);
		}

		[Ordinal(7)] 
		[RED("isForcedToTrue")] 
		public CBool IsForcedToTrue
		{
			get => GetProperty(ref _isForcedToTrue);
			set => SetProperty(ref _isForcedToTrue, value);
		}

		[Ordinal(8)] 
		[RED("supportBlendFromPose")] 
		public CBool SupportBlendFromPose
		{
			get => GetProperty(ref _supportBlendFromPose);
			set => SetProperty(ref _supportBlendFromPose, value);
		}

		[Ordinal(9)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get => GetProperty(ref _canRequestInertialization);
			set => SetProperty(ref _canRequestInertialization, value);
		}

		[Ordinal(10)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(11)] 
		[RED("actionAnimDatabaseRef")] 
		public CResourceReference<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get => GetProperty(ref _actionAnimDatabaseRef);
			set => SetProperty(ref _actionAnimDatabaseRef, value);
		}

		[Ordinal(12)] 
		[RED("isOutTransitionFromAction")] 
		public CBool IsOutTransitionFromAction
		{
			get => GetProperty(ref _isOutTransitionFromAction);
			set => SetProperty(ref _isOutTransitionFromAction, value);
		}

		public animAnimStateTransitionDescription()
		{
			_isEnabled = true;
		}
	}
}
