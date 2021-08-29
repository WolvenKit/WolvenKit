using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animEventsContainer : ISerializable
	{
		private CArray<CHandle<animAnimEvent>> _events;

		[Ordinal(0)] 
		[RED("events")] 
		public CArray<CHandle<animAnimEvent>> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}
	}
}
