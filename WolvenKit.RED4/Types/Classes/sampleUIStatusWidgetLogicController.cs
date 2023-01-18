using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUIStatusWidgetLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("enableStateColor")] 
		public CColor EnableStateColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("disableStateColor")] 
		public CColor DisableStateColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("iconWidget")] 
		public CWeakHandle<inkRectangleWidget> IconWidget
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		public sampleUIStatusWidgetLogicController()
		{
			EnableStateColor = new();
			DisableStateColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
