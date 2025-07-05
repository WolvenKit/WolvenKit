using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HotkeyConsumableWidgetController : gameuiNewPhoneRelatedHUDGameController
	{
		[Ordinal(15)] 
		[RED("radioSlot")] 
		public inkCompoundWidgetReference RadioSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("vehicleCustomizationSlot")] 
		public inkCompoundWidgetReference VehicleCustomizationSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("DpadHintLibraryPath")] 
		public inkWidgetLibraryReference DpadHintLibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(19)] 
		[RED("IsInDriverCombat")] 
		public CBool IsInDriverCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("IsPoliceVehicle")] 
		public CBool IsPoliceVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("isRadioBlocked")] 
		public CBool IsRadioBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("isInVehicleScene")] 
		public CBool IsInVehicleScene
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isQuestBlocked")] 
		public CBool IsQuestBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("carHudListenerId")] 
		public CUInt32 CarHudListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(25)] 
		[RED("statusListener")] 
		public CHandle<HotkeyRadioStatusListener> StatusListener
		{
			get => GetPropertyValue<CHandle<HotkeyRadioStatusListener>>();
			set => SetPropertyValue<CHandle<HotkeyRadioStatusListener>>(value);
		}

		[Ordinal(26)] 
		[RED("PlayerEnteredVehicleListener")] 
		public CHandle<redCallbackObject> PlayerEnteredVehicleListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public HotkeyConsumableWidgetController()
		{
			RadioSlot = new inkCompoundWidgetReference();
			VehicleCustomizationSlot = new inkCompoundWidgetReference();
			Container = new inkCompoundWidgetReference();
			DpadHintLibraryPath = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
