using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationBodyMorphOptionSelectorButton : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("overArrow")] 
		public inkWidgetReference OverArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public characterCreationBodyMorphOptionSelectorButton()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
