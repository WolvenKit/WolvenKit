using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksTabArrowClickedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<NewPerkTabsArrowDirection> Direction
		{
			get => GetPropertyValue<CEnum<NewPerkTabsArrowDirection>>();
			set => SetPropertyValue<CEnum<NewPerkTabsArrowDirection>>(value);
		}

		public NewPerksTabArrowClickedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
