using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PartInstallRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _itemID;
		private gameItemID _partID;

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(2)] 
		[RED("partID")] 
		public gameItemID PartID
		{
			get => GetProperty(ref _partID);
			set => SetProperty(ref _partID, value);
		}
	}
}
