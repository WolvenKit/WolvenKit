using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkHoverOverEvent : redEvent
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

		[Ordinal(2)] 
		[RED("perkData")] 
		public CHandle<NewPerkDisplayData> PerkData
		{
			get => GetPropertyValue<CHandle<NewPerkDisplayData>>();
			set => SetPropertyValue<CHandle<NewPerkDisplayData>>(value);
		}

		public NewPerkHoverOverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
