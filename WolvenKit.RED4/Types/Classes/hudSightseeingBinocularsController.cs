using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hudSightseeingBinocularsController : CustomAnimationsHudGameController
	{
		[Ordinal(19)] 
		[RED("pitch_min")] 
		public CFloat Pitch_min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("pitch_max")] 
		public CFloat Pitch_max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("yaw_min")] 
		public CFloat Yaw_min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("yaw_max")] 
		public CFloat Yaw_max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("tele_min")] 
		public CFloat Tele_min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("tele_max")] 
		public CFloat Tele_max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("tele_scale")] 
		public CFloat Tele_scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("max_zoom_level")] 
		public CFloat Max_zoom_level
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("background")] 
		public inkCanvasWidgetReference Background
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(29)] 
		[RED("tcsBlackboard")] 
		public CWeakHandle<gameIBlackboard> TcsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(30)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("tcs_BBID")] 
		public CHandle<redCallbackObject> Tcs_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("deviceChain_BBID")] 
		public CHandle<redCallbackObject> DeviceChain_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("controlledObjectRef")] 
		public CWeakHandle<gameObject> ControlledObjectRef
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(35)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(36)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(37)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(38)] 
		[RED("ownerObject")] 
		public CWeakHandle<gameObject> OwnerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(39)] 
		[RED("maxZoomLevel")] 
		public CInt32 MaxZoomLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public hudSightseeingBinocularsController()
		{
			Pitch_min = -360.000000F;
			Pitch_max = 360.000000F;
			Yaw_min = -640.000000F;
			Yaw_max = 640.000000F;
			Tele_min = -360.000000F;
			Tele_max = 360.000000F;
			Tele_scale = 0.750000F;
			Max_zoom_level = 4.000000F;
			Background = new inkCanvasWidgetReference();
			AnimOptions = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
