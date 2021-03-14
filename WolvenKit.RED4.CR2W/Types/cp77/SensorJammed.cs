using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensorJammed : redEvent
	{
		private wCHandle<SensorDevice> _sensor;

		[Ordinal(0)] 
		[RED("sensor")] 
		public wCHandle<SensorDevice> Sensor
		{
			get
			{
				if (_sensor == null)
				{
					_sensor = (wCHandle<SensorDevice>) CR2WTypeManager.Create("whandle:SensorDevice", "sensor", cr2w, this);
				}
				return _sensor;
			}
			set
			{
				if (_sensor == value)
				{
					return;
				}
				_sensor = value;
				PropertySet(this);
			}
		}

		public SensorJammed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
