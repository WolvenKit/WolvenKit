using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Time : CVariable
	{
		private CInt32 _days;
		private CInt32 _hours;
		private CInt32 _minutes;

		[Ordinal(0)] 
		[RED("days")] 
		public CInt32 Days
		{
			get => GetProperty(ref _days);
			set => SetProperty(ref _days, value);
		}

		[Ordinal(1)] 
		[RED("hours")] 
		public CInt32 Hours
		{
			get => GetProperty(ref _hours);
			set => SetProperty(ref _hours, value);
		}

		[Ordinal(2)] 
		[RED("minutes")] 
		public CInt32 Minutes
		{
			get => GetProperty(ref _minutes);
			set => SetProperty(ref _minutes, value);
		}

		public Time(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
