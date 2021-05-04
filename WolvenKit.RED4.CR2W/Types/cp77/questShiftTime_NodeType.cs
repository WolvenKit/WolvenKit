using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShiftTime_NodeType : questITimeManagerNodeType
	{
		private CEnum<questETimeShiftType> _timeShiftType;
		private CBool _preventVisualGlitch;
		private CUInt32 _hours;
		private CUInt32 _minutes;
		private CUInt32 _seconds;

		[Ordinal(0)] 
		[RED("timeShiftType")] 
		public CEnum<questETimeShiftType> TimeShiftType
		{
			get => GetProperty(ref _timeShiftType);
			set => SetProperty(ref _timeShiftType, value);
		}

		[Ordinal(1)] 
		[RED("preventVisualGlitch")] 
		public CBool PreventVisualGlitch
		{
			get => GetProperty(ref _preventVisualGlitch);
			set => SetProperty(ref _preventVisualGlitch, value);
		}

		[Ordinal(2)] 
		[RED("hours")] 
		public CUInt32 Hours
		{
			get => GetProperty(ref _hours);
			set => SetProperty(ref _hours, value);
		}

		[Ordinal(3)] 
		[RED("minutes")] 
		public CUInt32 Minutes
		{
			get => GetProperty(ref _minutes);
			set => SetProperty(ref _minutes, value);
		}

		[Ordinal(4)] 
		[RED("seconds")] 
		public CUInt32 Seconds
		{
			get => GetProperty(ref _seconds);
			set => SetProperty(ref _seconds, value);
		}

		public questShiftTime_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
