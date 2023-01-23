using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FillTakeOverChainBBoardEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requesterID")] 
		public gamePersistentID RequesterID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		public FillTakeOverChainBBoardEvent()
		{
			RequesterID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
