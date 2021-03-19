using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRealtimeDelay_ConditionType : questITimeConditionType
	{
		private CUInt32 _hours;
		private CUInt32 _minutes;
		private CUInt32 _seconds;
		private CUInt32 _miliseconds;

		[Ordinal(0)] 
		[RED("hours")] 
		public CUInt32 Hours
		{
			get => GetProperty(ref _hours);
			set => SetProperty(ref _hours, value);
		}

		[Ordinal(1)] 
		[RED("minutes")] 
		public CUInt32 Minutes
		{
			get => GetProperty(ref _minutes);
			set => SetProperty(ref _minutes, value);
		}

		[Ordinal(2)] 
		[RED("seconds")] 
		public CUInt32 Seconds
		{
			get => GetProperty(ref _seconds);
			set => SetProperty(ref _seconds, value);
		}

		[Ordinal(3)] 
		[RED("miliseconds")] 
		public CUInt32 Miliseconds
		{
			get => GetProperty(ref _miliseconds);
			set => SetProperty(ref _miliseconds, value);
		}

		public questRealtimeDelay_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
