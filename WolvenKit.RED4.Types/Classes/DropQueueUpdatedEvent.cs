using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropQueueUpdatedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("dropQueue")] 
		public CArray<gameItemModParams> DropQueue
		{
			get => GetPropertyValue<CArray<gameItemModParams>>();
			set => SetPropertyValue<CArray<gameItemModParams>>(value);
		}

		public DropQueueUpdatedEvent()
		{
			DropQueue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
