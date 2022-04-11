using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUISoundsLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		public sampleUISoundsLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
