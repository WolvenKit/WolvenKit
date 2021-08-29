using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemData : RedBaseClass
	{
		private CBool _suppressIncomingEvents;
		private CBool _suppressOutgoingEvents;

		[Ordinal(0)] 
		[RED("suppressIncomingEvents")] 
		public CBool SuppressIncomingEvents
		{
			get => GetProperty(ref _suppressIncomingEvents);
			set => SetProperty(ref _suppressIncomingEvents, value);
		}

		[Ordinal(1)] 
		[RED("suppressOutgoingEvents")] 
		public CBool SuppressOutgoingEvents
		{
			get => GetProperty(ref _suppressOutgoingEvents);
			set => SetProperty(ref _suppressOutgoingEvents, value);
		}
	}
}
