using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsSelectorControllerList : SettingsSelectorControllerRange
	{
		[Ordinal(19)] 
		[RED("dotsContainer")] 
		public inkHorizontalPanelWidgetReference DotsContainer
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		public SettingsSelectorControllerList()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
