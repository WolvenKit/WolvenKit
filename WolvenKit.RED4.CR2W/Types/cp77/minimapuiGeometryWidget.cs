using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class minimapuiGeometryWidget : inkCanvasWidget
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

		public minimapuiGeometryWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
