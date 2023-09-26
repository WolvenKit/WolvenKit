using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkTabsArrowController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<NewPerkTabsArrowDirection> Direction
		{
			get => GetPropertyValue<CEnum<NewPerkTabsArrowDirection>>();
			set => SetPropertyValue<CEnum<NewPerkTabsArrowDirection>>(value);
		}

		[Ordinal(2)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("pressed")] 
		public CBool Pressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NewPerkTabsArrowController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
