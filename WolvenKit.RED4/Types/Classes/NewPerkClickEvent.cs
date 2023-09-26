using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkClickEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<NewPerksPerkItemLogicController> Controller
		{
			get => GetPropertyValue<CWeakHandle<NewPerksPerkItemLogicController>>();
			set => SetPropertyValue<CWeakHandle<NewPerksPerkItemLogicController>>(value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CName Action
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public NewPerkClickEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
