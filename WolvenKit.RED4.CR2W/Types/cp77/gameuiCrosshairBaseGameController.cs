using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCrosshairBaseGameController : gameuiWidgetGameController
	{
		private wCHandle<inkWidget> _rootWidget;
		private CEnum<gamePSMCrosshairStates> _crosshairState;
		private CEnum<gamePSMVision> _visionState;
		private CHandle<redCallbackObject> _crosshairStateBlackboardId;
		private CHandle<redCallbackObject> _bulletSpreedBlackboardId;
		private CUInt32 _bbNPCStatsId;
		private CBool _isTargetDead;
		private CUInt64 _lastGUIStateUpdateFrame;
		private wCHandle<gameIBlackboard> _targetBB;
		private wCHandle<gameIBlackboard> _weaponBB;
		private CHandle<redCallbackObject> _currentAimTargetBBID;
		private CHandle<redCallbackObject> _targetDistanceBBID;
		private CHandle<redCallbackObject> _targetAttitudeBBID;
		private wCHandle<entEntity> _targetEntity;
		private CHandle<CrosshairHealthChangeListener> _healthListener;
		private CBool _isActive;

		[Ordinal(2)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(3)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get => GetProperty(ref _crosshairState);
			set => SetProperty(ref _crosshairState, value);
		}

		[Ordinal(4)] 
		[RED("visionState")] 
		public CEnum<gamePSMVision> VisionState
		{
			get => GetProperty(ref _visionState);
			set => SetProperty(ref _visionState, value);
		}

		[Ordinal(5)] 
		[RED("crosshairStateBlackboardId")] 
		public CHandle<redCallbackObject> CrosshairStateBlackboardId
		{
			get => GetProperty(ref _crosshairStateBlackboardId);
			set => SetProperty(ref _crosshairStateBlackboardId, value);
		}

		[Ordinal(6)] 
		[RED("bulletSpreedBlackboardId")] 
		public CHandle<redCallbackObject> BulletSpreedBlackboardId
		{
			get => GetProperty(ref _bulletSpreedBlackboardId);
			set => SetProperty(ref _bulletSpreedBlackboardId, value);
		}

		[Ordinal(7)] 
		[RED("bbNPCStatsId")] 
		public CUInt32 BbNPCStatsId
		{
			get => GetProperty(ref _bbNPCStatsId);
			set => SetProperty(ref _bbNPCStatsId, value);
		}

		[Ordinal(8)] 
		[RED("isTargetDead")] 
		public CBool IsTargetDead
		{
			get => GetProperty(ref _isTargetDead);
			set => SetProperty(ref _isTargetDead, value);
		}

		[Ordinal(9)] 
		[RED("lastGUIStateUpdateFrame")] 
		public CUInt64 LastGUIStateUpdateFrame
		{
			get => GetProperty(ref _lastGUIStateUpdateFrame);
			set => SetProperty(ref _lastGUIStateUpdateFrame, value);
		}

		[Ordinal(10)] 
		[RED("targetBB")] 
		public wCHandle<gameIBlackboard> TargetBB
		{
			get => GetProperty(ref _targetBB);
			set => SetProperty(ref _targetBB, value);
		}

		[Ordinal(11)] 
		[RED("weaponBB")] 
		public wCHandle<gameIBlackboard> WeaponBB
		{
			get => GetProperty(ref _weaponBB);
			set => SetProperty(ref _weaponBB, value);
		}

		[Ordinal(12)] 
		[RED("currentAimTargetBBID")] 
		public CHandle<redCallbackObject> CurrentAimTargetBBID
		{
			get => GetProperty(ref _currentAimTargetBBID);
			set => SetProperty(ref _currentAimTargetBBID, value);
		}

		[Ordinal(13)] 
		[RED("targetDistanceBBID")] 
		public CHandle<redCallbackObject> TargetDistanceBBID
		{
			get => GetProperty(ref _targetDistanceBBID);
			set => SetProperty(ref _targetDistanceBBID, value);
		}

		[Ordinal(14)] 
		[RED("targetAttitudeBBID")] 
		public CHandle<redCallbackObject> TargetAttitudeBBID
		{
			get => GetProperty(ref _targetAttitudeBBID);
			set => SetProperty(ref _targetAttitudeBBID, value);
		}

		[Ordinal(15)] 
		[RED("targetEntity")] 
		public wCHandle<entEntity> TargetEntity
		{
			get => GetProperty(ref _targetEntity);
			set => SetProperty(ref _targetEntity, value);
		}

		[Ordinal(16)] 
		[RED("healthListener")] 
		public CHandle<CrosshairHealthChangeListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		[Ordinal(17)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		public gameuiCrosshairBaseGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
