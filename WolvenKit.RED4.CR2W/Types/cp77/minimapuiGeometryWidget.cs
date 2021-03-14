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
			get
			{
				if (_widgetTemplates == null)
				{
					_widgetTemplates = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "widgetTemplates", cr2w, this);
				}
				return _widgetTemplates;
			}
			set
			{
				if (_widgetTemplates == value)
				{
					return;
				}
				_widgetTemplates = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("settings")] 
		public minimapuiSettings Settings
		{
			get
			{
				if (_settings == null)
				{
					_settings = (minimapuiSettings) CR2WTypeManager.Create("minimapuiSettings", "settings", cr2w, this);
				}
				return _settings;
			}
			set
			{
				if (_settings == value)
				{
					return;
				}
				_settings = value;
				PropertySet(this);
			}
		}

		public minimapuiGeometryWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
