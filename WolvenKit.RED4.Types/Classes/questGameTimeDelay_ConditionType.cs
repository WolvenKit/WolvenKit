using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questGameTimeDelay_ConditionType : questITimeConditionType
	{
		private CUInt32 _days;
		private CUInt32 _hours;
		private CUInt32 _minutes;
		private CUInt32 _seconds;

		[Ordinal(0)] 
		[RED("days")] 
		public CUInt32 Days
		{
			get => GetProperty(ref _days);
			set => SetProperty(ref _days, value);
		}

		[Ordinal(1)] 
		[RED("hours")] 
		public CUInt32 Hours
		{
			get => GetProperty(ref _hours);
			set => SetProperty(ref _hours, value);
		}

		[Ordinal(2)] 
		[RED("minutes")] 
		public CUInt32 Minutes
		{
			get => GetProperty(ref _minutes);
			set => SetProperty(ref _minutes, value);
		}

		[Ordinal(3)] 
		[RED("seconds")] 
		public CUInt32 Seconds
		{
			get => GetProperty(ref _seconds);
			set => SetProperty(ref _seconds, value);
		}
	}
}
