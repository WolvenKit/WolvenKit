using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hudCameraController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("pitch_min")] 
		public CFloat Pitch_min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("pitch_max")] 
		public CFloat Pitch_max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("yaw_min")] 
		public CFloat Yaw_min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("yaw_max")] 
		public CFloat Yaw_max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("tele_min")] 
		public CFloat Tele_min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("tele_max")] 
		public CFloat Tele_max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("tele_scale")] 
		public CFloat Tele_scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("max_zoom_level")] 
		public CFloat Max_zoom_level
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("dateAndTimeHolder")] 
		public inkHorizontalPanelWidgetReference DateAndTimeHolder
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("recHolder")] 
		public inkCanvasWidgetReference RecHolder
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("Date")] 
		public inkTextWidgetReference Date
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("Timer")] 
		public inkTextWidgetReference Timer
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("CameraID")] 
		public inkTextWidgetReference CameraID
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("timerHrs")] 
		public inkTextWidgetReference TimerHrs
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("timerMin")] 
		public inkTextWidgetReference TimerMin
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("timerSec")] 
		public inkTextWidgetReference TimerSec
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("watermark")] 
		public inkWidgetReference Watermark
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("yawCounter")] 
		public inkTextWidgetReference YawCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("pitchCounter")] 
		public inkTextWidgetReference PitchCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("pitch")] 
		public inkCanvasWidgetReference Pitch
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("yaw")] 
		public inkCanvasWidgetReference Yaw
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("tele")] 
		public inkCanvasWidgetReference Tele
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("teleScale")] 
		public inkCanvasWidgetReference TeleScale
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(33)] 
		[RED("tcsBlackboard")] 
		public CWeakHandle<gameIBlackboard> TcsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(34)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("tcs_BBID")] 
		public CHandle<redCallbackObject> Tcs_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("deviceChain_BBID")] 
		public CHandle<redCallbackObject> DeviceChain_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(37)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(38)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("controlledObjectRef")] 
		public CWeakHandle<gameObject> ControlledObjectRef
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(40)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(41)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(42)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(43)] 
		[RED("ownerObject")] 
		public CWeakHandle<gameObject> OwnerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(44)] 
		[RED("maxZoomLevel")] 
		public CInt32 MaxZoomLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(45)] 
		[RED("overclockListener")] 
		public CHandle<OverclockHudListener> OverclockListener
		{
			get => GetPropertyValue<CHandle<OverclockHudListener>>();
			set => SetPropertyValue<CHandle<OverclockHudListener>>(value);
		}

		[Ordinal(46)] 
		[RED("isOverclockActive")] 
		public CBool IsOverclockActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("canActivateOverclock")] 
		public CBool CanActivateOverclock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public hudCameraController()
		{
			Pitch_min = -360.000000F;
			Pitch_max = 360.000000F;
			Yaw_min = -640.000000F;
			Yaw_max = 640.000000F;
			Tele_min = -360.000000F;
			Tele_max = 360.000000F;
			Tele_scale = 0.750000F;
			Max_zoom_level = 4.000000F;
			DateAndTimeHolder = new inkHorizontalPanelWidgetReference();
			RecHolder = new inkCanvasWidgetReference();
			Date = new inkTextWidgetReference();
			Timer = new inkTextWidgetReference();
			CameraID = new inkTextWidgetReference();
			TimerHrs = new inkTextWidgetReference();
			TimerMin = new inkTextWidgetReference();
			TimerSec = new inkTextWidgetReference();
			Watermark = new inkWidgetReference();
			YawCounter = new inkTextWidgetReference();
			PitchCounter = new inkTextWidgetReference();
			Pitch = new inkCanvasWidgetReference();
			Yaw = new inkCanvasWidgetReference();
			Tele = new inkCanvasWidgetReference();
			TeleScale = new inkCanvasWidgetReference();
			AnimOptions = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
