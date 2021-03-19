using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTime_NodeType : questITimeManagerNodeType
	{
		private CInt32 _hours;
		private CInt32 _minutes;
		private CInt32 _seconds;
		private CName _source;

		[Ordinal(0)] 
		[RED("hours")] 
		public CInt32 Hours
		{
			get => GetProperty(ref _hours);
			set => SetProperty(ref _hours, value);
		}

		[Ordinal(1)] 
		[RED("minutes")] 
		public CInt32 Minutes
		{
			get => GetProperty(ref _minutes);
			set => SetProperty(ref _minutes, value);
		}

		[Ordinal(2)] 
		[RED("seconds")] 
		public CInt32 Seconds
		{
			get => GetProperty(ref _seconds);
			set => SetProperty(ref _seconds, value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public questSetTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
