using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class minimapuiGeometryWidget : inkCanvasWidget
	{
		[Ordinal(23)] 
		[RED("widgetTemplates")] 
		public CArray<inkWidgetReference> WidgetTemplates
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(24)] 
		[RED("settings")] 
		public minimapuiSettings Settings
		{
			get => GetPropertyValue<minimapuiSettings>();
			set => SetPropertyValue<minimapuiSettings>(value);
		}

		public minimapuiGeometryWidget()
		{
			WidgetTemplates = new() { new(), new(), new(), new(), new(), new(), new() };
			Settings = new() { ShowTime = 0.300000F, HideTime = 0.250000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
