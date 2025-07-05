using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class inkIWidgetSlotController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("layout")] 
		public inkWidgetLayout Layout
		{
			get => GetPropertyValue<inkWidgetLayout>();
			set => SetPropertyValue<inkWidgetLayout>(value);
		}

		public inkIWidgetSlotController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
