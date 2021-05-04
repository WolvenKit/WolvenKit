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
			get => GetProperty(ref _stationNameWidget);
			set => SetProperty(ref _stationNameWidget, value);
		}

		[Ordinal(17)] 
		[RED("stationLogoWidget")] 
		public inkImageWidgetReference StationLogoWidget
		{
			get => GetProperty(ref _stationLogoWidget);
			set => SetProperty(ref _stationLogoWidget, value);
		}

		public RadioInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
