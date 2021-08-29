using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class buildsWidgetGameController : gameuiWidgetGameController
	{
		private CArray<CWeakHandle<inkHorizontalPanelWidget>> _horizontalPanelsList;

		[Ordinal(2)] 
		[RED("horizontalPanelsList")] 
		public CArray<CWeakHandle<inkHorizontalPanelWidget>> HorizontalPanelsList
		{
			get => GetProperty(ref _horizontalPanelsList);
			set => SetProperty(ref _horizontalPanelsList, value);
		}
	}
}
