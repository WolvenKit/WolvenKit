using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropQueueUpdatedEvent : redEvent
	{
		private CArray<gameItemModParams> _dropQueue;

		[Ordinal(0)] 
		[RED("dropQueue")] 
		public CArray<gameItemModParams> DropQueue
		{
			get => GetProperty(ref _dropQueue);
			set => SetProperty(ref _dropQueue, value);
		}
	}
}
