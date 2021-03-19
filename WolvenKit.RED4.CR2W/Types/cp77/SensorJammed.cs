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
			get => GetProperty(ref _sensor);
			set => SetProperty(ref _sensor, value);
		}

		public SensorJammed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
