using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class buildsWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("horizontalPanelsList")] 
		public CArray<CWeakHandle<inkHorizontalPanelWidget>> HorizontalPanelsList
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkHorizontalPanelWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkHorizontalPanelWidget>>>(value);
		}

		public buildsWidgetGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
