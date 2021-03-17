using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDynamicEventsWithInterval : CVariable
	{
		private CArray<CName> _events;
		private CFloat _interval;

		[Ordinal(0)] 
		[RED("events")] 
		public CArray<CName> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}

		[Ordinal(1)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetProperty(ref _interval);
			set => SetProperty(ref _interval, value);
		}

		public audioDynamicEventsWithInterval(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
