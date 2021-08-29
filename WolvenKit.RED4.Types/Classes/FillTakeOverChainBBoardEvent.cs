using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FillTakeOverChainBBoardEvent : redEvent
	{
		private gamePersistentID _requesterID;

		[Ordinal(0)] 
		[RED("requesterID")] 
		public gamePersistentID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}
	}
}
