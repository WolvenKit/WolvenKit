using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardCollectedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("entry")] 
		public CHandle<gameJournalOnscreen> Entry
		{
			get => GetPropertyValue<CHandle<gameJournalOnscreen>>();
			set => SetPropertyValue<CHandle<gameJournalOnscreen>>(value);
		}

		[Ordinal(6)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(8)] 
		[RED("shardTitle")] 
		public CString ShardTitle
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ShardCollectedNotificationViewData()
		{
			ItemID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
