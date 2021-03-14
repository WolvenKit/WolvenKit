using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioInkGameController : DeviceInkGameControllerBase
	{
		private inkTextWidgetReference _stationNameWidget;
		private inkImageWidgetReference _stationLogoWidget;

		[Ordinal(16)] 
		[RED("stationNameWidget")] 
		public inkTextWidgetReference StationNameWidget
		{
			get
			{
				if (_stationNameWidget == null)
				{
					_stationNameWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "stationNameWidget", cr2w, this);
				}
				return _stationNameWidget;
			}
			set
			{
				if (_stationNameWidget == value)
				{
					return;
				}
				_stationNameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("stationLogoWidget")] 
		public inkImageWidgetReference StationLogoWidget
		{
			get
			{
				if (_stationLogoWidget == null)
				{
					_stationLogoWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "stationLogoWidget", cr2w, this);
				}
				return _stationLogoWidget;
			}
			set
			{
				if (_stationLogoWidget == value)
				{
					return;
				}
				_stationLogoWidget = value;
				PropertySet(this);
			}
		}

		public RadioInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
