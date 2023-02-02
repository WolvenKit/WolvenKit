using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NotifyShardRead : redEvent
	{
		[Ordinal(0)] 
		[RED("entry")] 
		public CHandle<gameJournalOnscreen> Entry
		{
			get => GetPropertyValue<CHandle<gameJournalOnscreen>>();
			set => SetPropertyValue<CHandle<gameJournalOnscreen>>(value);
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public NotifyShardRead()
		{
			ItemID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
