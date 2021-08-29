using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class minimapuiGeometryWidget : inkCanvasWidget
	{
		private CArray<inkWidgetReference> _widgetTemplates;
		private minimapuiSettings _settings;

		[Ordinal(23)] 
		[RED("widgetTemplates")] 
		public CArray<inkWidgetReference> WidgetTemplates
		{
			get => GetProperty(ref _widgetTemplates);
			set => SetProperty(ref _widgetTemplates, value);
		}

		[Ordinal(24)] 
		[RED("settings")] 
		public minimapuiSettings Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}
	}
}
