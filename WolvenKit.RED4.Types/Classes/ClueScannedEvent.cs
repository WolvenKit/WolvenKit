using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClueScannedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ClueScannedEvent()
		{
			RequesterID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
