using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CasinoTableSlotData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public inkWidgetReference Widget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public CWeakHandle<CasinoTableSlotLogicController> Controller
		{
			get => GetPropertyValue<CWeakHandle<CasinoTableSlotLogicController>>();
			set => SetPropertyValue<CWeakHandle<CasinoTableSlotLogicController>>(value);
		}

		[Ordinal(2)] 
		[RED("casinoChipsListener")] 
		public CWeakHandle<gameInventoryScriptListener> CasinoChipsListener
		{
			get => GetPropertyValue<CWeakHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CWeakHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(3)] 
		[RED("slotUser")] 
		public CWeakHandle<gameObject> SlotUser
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public CasinoTableSlotData()
		{
			Widget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
