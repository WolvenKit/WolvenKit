using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleAirtime_ConditionType : questIVehicleConditionType
	{
		private CFloat _seconds;

		[Ordinal(0)] 
		[RED("seconds")] 
		public CFloat Seconds
		{
			get => GetProperty(ref _seconds);
			set => SetProperty(ref _seconds, value);
		}
	}
}
