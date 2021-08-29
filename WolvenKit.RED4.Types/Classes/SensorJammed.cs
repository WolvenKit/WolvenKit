using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SensorJammed : redEvent
	{
		private CWeakHandle<SensorDevice> _sensor;

		[Ordinal(0)] 
		[RED("sensor")] 
		public CWeakHandle<SensorDevice> Sensor
		{
			get => GetProperty(ref _sensor);
			set => SetProperty(ref _sensor, value);
		}
	}
}
