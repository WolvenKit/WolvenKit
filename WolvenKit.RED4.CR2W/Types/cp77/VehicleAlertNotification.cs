using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleAlertNotification : GenericNotificationController
	{
		private CHandle<inkanimProxy> _animation;
		private CHandle<VehicleAlertNotificationViewData> _zone_data;
		private inkTextWidgetReference _zoneLabelText;

		[Ordinal(12)] 
		[RED("animation")] 
		public CHandle<inkanimProxy> Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(13)] 
		[RED("zone_data")] 
		public CHandle<VehicleAlertNotificationViewData> Zone_data
		{
			get => GetProperty(ref _zone_data);
			set => SetProperty(ref _zone_data, value);
		}

		[Ordinal(14)] 
		[RED("ZoneLabelText")] 
		public inkTextWidgetReference ZoneLabelText
		{
			get => GetProperty(ref _zoneLabelText);
			set => SetProperty(ref _zoneLabelText, value);
		}

		public VehicleAlertNotification(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
