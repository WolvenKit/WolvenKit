using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hudTurretController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("Date")] 
		public inkTextWidgetReference Date
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("Timer")] 
		public inkTextWidgetReference Timer
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("CameraID")] 
		public inkTextWidgetReference CameraID
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("healthStatus")] 
		public inkTextWidgetReference HealthStatus
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("MessageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("pitchFluff")] 
		public inkTextWidgetReference PitchFluff
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("yawFluff")] 
		public inkTextWidgetReference YawFluff
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("offsetLeft")] 
		public CFloat OffsetLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("offsetRight")] 
		public CFloat OffsetRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(21)] 
		[RED("bbPlayerStats")] 
		public CWeakHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(22)] 
		[RED("bbPlayerEventId")] 
		public CHandle<redCallbackObject> BbPlayerEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(27)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(28)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(29)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public hudTurretController()
		{
			Date = new inkTextWidgetReference();
			Timer = new inkTextWidgetReference();
			CameraID = new inkTextWidgetReference();
			HealthStatus = new inkTextWidgetReference();
			MessageText = new inkTextWidgetReference();
			PitchFluff = new inkTextWidgetReference();
			YawFluff = new inkTextWidgetReference();
			LeftPart = new inkWidgetReference();
			RightPart = new inkWidgetReference();
			OffsetLeft = -838.000000F;
			OffsetRight = 1495.000000F;
			CurrentTime = new GameTime();
			GameInstance = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
