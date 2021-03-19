using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NotifyShardRead : redEvent
	{
		private CHandle<gameJournalOnscreen> _entry;
		private CString _title;
		private CString _text;
		private CBool _isCrypted;
		private gameItemID _itemID;

		[Ordinal(0)] 
		[RED("entry")] 
		public CHandle<gameJournalOnscreen> Entry
		{
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(3)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get => GetProperty(ref _isCrypted);
			set => SetProperty(ref _isCrypted, value);
		}

		[Ordinal(4)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		public NotifyShardRead(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
