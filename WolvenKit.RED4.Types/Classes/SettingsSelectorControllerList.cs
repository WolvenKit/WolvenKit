using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsSelectorControllerList : SettingsSelectorControllerRange
	{
		private inkHorizontalPanelWidgetReference _dotsContainer;

		[Ordinal(19)] 
		[RED("dotsContainer")] 
		public inkHorizontalPanelWidgetReference DotsContainer
		{
			get => GetProperty(ref _dotsContainer);
			set => SetProperty(ref _dotsContainer, value);
		}
	}
}
