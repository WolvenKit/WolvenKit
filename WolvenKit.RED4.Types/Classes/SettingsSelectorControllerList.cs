using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			DotsContainer = new();
		}
	}
}
