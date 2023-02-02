using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCrosshairBaseGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get => GetPropertyValue<CEnum<gamePSMCrosshairStates>>();
			set => SetPropertyValue<CEnum<gamePSMCrosshairStates>>(value);
		}

		[Ordinal(4)] 
		[RED("visionState")] 
		public CEnum<gamePSMVision> VisionState
		{
			get => GetPropertyValue<CEnum<gamePSMVision>>();
			set => SetPropertyValue<CEnum<gamePSMVision>>(value);
		}

		[Ordinal(5)] 
		[RED("crosshairStateBlackboardId")] 
		public CHandle<redCallbackObject> CrosshairStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("bulletSpreedBlackboardId")] 
		public CHandle<redCallbackObject> BulletSpreedBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("bbNPCStatsId")] 
		public CUInt32 BbNPCStatsId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("isTargetDead")] 
		public CBool IsTargetDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("lastGUIStateUpdateFrame")] 
		public CUInt64 LastGUIStateUpdateFrame
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(10)] 
		[RED("targetBB")] 
		public CWeakHandle<gameIBlackboard> TargetBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("weaponBB")] 
		public CWeakHandle<gameIBlackboard> WeaponBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(12)] 
		[RED("currentAimTargetBBID")] 
		public CHandle<redCallbackObject> CurrentAimTargetBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("targetDistanceBBID")] 
		public CHandle<redCallbackObject> TargetDistanceBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("targetAttitudeBBID")] 
		public CHandle<redCallbackObject> TargetAttitudeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("targetEntity")] 
		public CWeakHandle<entEntity> TargetEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(16)] 
		[RED("healthListener")] 
		public CHandle<CrosshairHealthChangeListener> HealthListener
		{
			get => GetPropertyValue<CHandle<CrosshairHealthChangeListener>>();
			set => SetPropertyValue<CHandle<CrosshairHealthChangeListener>>(value);
		}

		[Ordinal(17)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiCrosshairBaseGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
