using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoneAlertNotification : GenericNotificationController
	{
		private CHandle<inkanimProxy> _animation;
		private CHandle<ZoneAlertNotificationViewData> _zone_data;
		private inkTextWidgetReference _zoneLabelText;

		[Ordinal(12)] 
		[RED("animation")] 
		public CHandle<inkanimProxy> Animation
		{
			get
			{
				if (_animation == null)
				{
					_animation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animation", cr2w, this);
				}
				return _animation;
			}
			set
			{
				if (_animation == value)
				{
					return;
				}
				_animation = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("zone_data")] 
		public CHandle<ZoneAlertNotificationViewData> Zone_data
		{
			get
			{
				if (_zone_data == null)
				{
					_zone_data = (CHandle<ZoneAlertNotificationViewData>) CR2WTypeManager.Create("handle:ZoneAlertNotificationViewData", "zone_data", cr2w, this);
				}
				return _zone_data;
			}
			set
			{
				if (_zone_data == value)
				{
					return;
				}
				_zone_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("ZoneLabelText")] 
		public inkTextWidgetReference ZoneLabelText
		{
			get
			{
				if (_zoneLabelText == null)
				{
					_zoneLabelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ZoneLabelText", cr2w, this);
				}
				return _zoneLabelText;
			}
			set
			{
				if (_zoneLabelText == value)
				{
					return;
				}
				_zoneLabelText = value;
				PropertySet(this);
			}
		}

		public ZoneAlertNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
