using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WardrobeOutfitSlotHoverOverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("evt")] 
		public CHandle<inkPointerEvent> Evt
		{
			get => GetPropertyValue<CHandle<inkPointerEvent>>();
			set => SetPropertyValue<CHandle<inkPointerEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public CWeakHandle<WardrobeOutfitSlotController> Controller
		{
			get => GetPropertyValue<CWeakHandle<WardrobeOutfitSlotController>>();
			set => SetPropertyValue<CWeakHandle<WardrobeOutfitSlotController>>(value);
		}

		public WardrobeOutfitSlotHoverOverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
