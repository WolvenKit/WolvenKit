using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardReadPopupData : inkGameNotificationData
	{
		private CString _title;
		private CString _text;
		private CBool _isCrypted;
		private gameItemID _itemID;

		[Ordinal(6)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(7)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(8)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get => GetProperty(ref _isCrypted);
			set => SetProperty(ref _isCrypted, value);
		}

		[Ordinal(9)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		public ShardReadPopupData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
