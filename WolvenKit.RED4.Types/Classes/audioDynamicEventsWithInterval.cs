using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioDynamicEventsWithInterval : RedBaseClass
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
	}
}
