using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkHoverOutEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<NewPerksPerkItemLogicController> Controller
		{
			get => GetPropertyValue<CWeakHandle<NewPerksPerkItemLogicController>>();
			set => SetPropertyValue<CWeakHandle<NewPerksPerkItemLogicController>>(value);
		}

		[Ordinal(1)] 
		[RED("evt")] 
		public CHandle<inkPointerEvent> Evt
		{
			get => GetPropertyValue<CHandle<inkPointerEvent>>();
			set => SetPropertyValue<CHandle<inkPointerEvent>>(value);
		}

		public NewPerkHoverOutEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
