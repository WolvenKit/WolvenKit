using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapPreventionVehicleMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("visionWidget")] 
		public inkWidgetReference VisionWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("outerIcon")] 
		public inkImageWidgetReference OuterIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("maxTackIcon")] 
		public inkImageWidgetReference MaxTackIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("fadeInAnimName")] 
		public CName FadeInAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("fadeOutAnimName")] 
		public CName FadeOutAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("fadeAnimProxy")] 
		public CHandle<inkanimProxy> FadeAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("UIWantedBarBB")] 
		public CWeakHandle<gameIBlackboard> UIWantedBarBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(22)] 
		[RED("UIWantedBarDef")] 
		public CHandle<UI_WantedBarDef> UIWantedBarDef
		{
			get => GetPropertyValue<CHandle<UI_WantedBarDef>>();
			set => SetPropertyValue<CHandle<UI_WantedBarDef>>(value);
		}

		[Ordinal(23)] 
		[RED("currentWantedStateCallback")] 
		public CHandle<redCallbackObject> CurrentWantedStateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("playerEscapingPursuit")] 
		public CBool PlayerEscapingPursuit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("playerWanted")] 
		public CBool PlayerWanted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("mappinState")] 
		public CName MappinState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("keepIconOnClamping")] 
		public CBool KeepIconOnClamping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("maxVisibilityDistance")] 
		public CFloat MaxVisibilityDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("currentChaseState")] 
		public CName CurrentChaseState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("detectionDropThreshold")] 
		public CFloat DetectionDropThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("wasMaxDetectionReached")] 
		public CBool WasMaxDetectionReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(33)] 
		[RED("isMaxTacAV")] 
		public CBool IsMaxTacAV
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiMinimapPreventionVehicleMappinController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
