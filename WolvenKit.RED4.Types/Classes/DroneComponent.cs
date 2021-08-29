using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DroneComponent : gameScriptableComponent
	{
		private CHandle<senseComponent> _senseComponent;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
		private CHandle<entSimpleColliderComponent> _playerOnlyCollisionComponent;
		private CUInt32 _highLevelCb;
		private CEnum<MechanicalScanType> _currentScanType;
		private CHandle<gameEffectInstance> _currentScanEffect;
		private CName _currentScanAnimation;
		private CBool _isDetectionScanning;
		private CWeakHandle<gameObject> _trackedTarget;
		private CName _currentLocomotionWrapper;

		[Ordinal(5)] 
		[RED("senseComponent")] 
		public CHandle<senseComponent> SenseComponent
		{
			get => GetProperty(ref _senseComponent);
			set => SetProperty(ref _senseComponent, value);
		}

		[Ordinal(6)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetProperty(ref _npcCollisionComponent);
			set => SetProperty(ref _npcCollisionComponent, value);
		}

		[Ordinal(7)] 
		[RED("playerOnlyCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> PlayerOnlyCollisionComponent
		{
			get => GetProperty(ref _playerOnlyCollisionComponent);
			set => SetProperty(ref _playerOnlyCollisionComponent, value);
		}

		[Ordinal(8)] 
		[RED("highLevelCb")] 
		public CUInt32 HighLevelCb
		{
			get => GetProperty(ref _highLevelCb);
			set => SetProperty(ref _highLevelCb, value);
		}

		[Ordinal(9)] 
		[RED("currentScanType")] 
		public CEnum<MechanicalScanType> CurrentScanType
		{
			get => GetProperty(ref _currentScanType);
			set => SetProperty(ref _currentScanType, value);
		}

		[Ordinal(10)] 
		[RED("currentScanEffect")] 
		public CHandle<gameEffectInstance> CurrentScanEffect
		{
			get => GetProperty(ref _currentScanEffect);
			set => SetProperty(ref _currentScanEffect, value);
		}

		[Ordinal(11)] 
		[RED("currentScanAnimation")] 
		public CName CurrentScanAnimation
		{
			get => GetProperty(ref _currentScanAnimation);
			set => SetProperty(ref _currentScanAnimation, value);
		}

		[Ordinal(12)] 
		[RED("isDetectionScanning")] 
		public CBool IsDetectionScanning
		{
			get => GetProperty(ref _isDetectionScanning);
			set => SetProperty(ref _isDetectionScanning, value);
		}

		[Ordinal(13)] 
		[RED("trackedTarget")] 
		public CWeakHandle<gameObject> TrackedTarget
		{
			get => GetProperty(ref _trackedTarget);
			set => SetProperty(ref _trackedTarget, value);
		}

		[Ordinal(14)] 
		[RED("currentLocomotionWrapper")] 
		public CName CurrentLocomotionWrapper
		{
			get => GetProperty(ref _currentLocomotionWrapper);
			set => SetProperty(ref _currentLocomotionWrapper, value);
		}
	}
}
