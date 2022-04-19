using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class at_uiWidgetData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widgetATID")] 
		public CString WidgetATID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("layerType")] 
		public CEnum<inkELayerType> LayerType
		{
			get => GetPropertyValue<CEnum<inkELayerType>>();
			set => SetPropertyValue<CEnum<inkELayerType>>(value);
		}

		[Ordinal(2)] 
		[RED("parentGameController")] 
		public CName ParentGameController
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public at_uiWidgetData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
