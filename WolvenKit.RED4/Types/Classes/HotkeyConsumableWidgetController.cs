using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HotkeyConsumableWidgetController : gameuiNewPhoneRelatedHUDGameController
	{
		[Ordinal(16)] 
		[RED("radioSlot")] 
		public inkCompoundWidgetReference RadioSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("vehicleCustomizationSlot")] 
		public inkCompoundWidgetReference VehicleCustomizationSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("autodriveSlot")] 
		public inkCompoundWidgetReference AutodriveSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("DpadHintLibraryPath")] 
		public inkWidgetLibraryReference DpadHintLibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(21)] 
		[RED("autodriveLibraryPath")] 
		public inkWidgetLibraryReference AutodriveLibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(22)] 
		[RED("IsInDriverCombat")] 
		public CBool IsInDriverCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("IsPoliceVehicle")] 
		public CBool IsPoliceVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("isRadioBlocked")] 
		public CBool IsRadioBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("isInVehicleScene")] 
		public CBool IsInVehicleScene
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("isQuestBlocked")] 
		public CBool IsQuestBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("carHudListenerId")] 
		public CUInt32 CarHudListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(28)] 
		[RED("statusListener")] 
		public CHandle<HotkeyRadioStatusListener> StatusListener
		{
			get => GetPropertyValue<CHandle<HotkeyRadioStatusListener>>();
			set => SetPropertyValue<CHandle<HotkeyRadioStatusListener>>(value);
		}

		[Ordinal(29)] 
		[RED("PlayerEnteredVehicleListener")] 
		public CHandle<redCallbackObject> PlayerEnteredVehicleListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("autodriveToggledListener")] 
		public CHandle<redCallbackObject> AutodriveToggledListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("containerAnimProxy")] 
		public CHandle<inkanimProxy> ContainerAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(32)] 
		[RED("containerVisibility")] 
		public CBool ContainerVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HotkeyConsumableWidgetController()
		{
			RadioSlot = new inkCompoundWidgetReference();
			VehicleCustomizationSlot = new inkCompoundWidgetReference();
			AutodriveSlot = new inkCompoundWidgetReference();
			Container = new inkCompoundWidgetReference();
			DpadHintLibraryPath = new inkWidgetLibraryReference();
			AutodriveLibraryPath = new inkWidgetLibraryReference();
			ContainerVisibility = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
