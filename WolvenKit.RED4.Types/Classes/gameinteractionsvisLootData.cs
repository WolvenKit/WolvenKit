using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisLootData : RedBaseClass
	{
		private CBool _isActive;
		private CBool _isListOpen;
		private CBool _e3hack_isWeapon;
		private CInt32 _currentIndex;
		private CString _title;
		private CArray<gameinteractionsvisInteractionChoiceData> _choices;
		private CArray<gameItemID> _itemIDs;
		private entEntityID _ownerId;
		private CBool _isLocked;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("isListOpen")] 
		public CBool IsListOpen
		{
			get => GetProperty(ref _isListOpen);
			set => SetProperty(ref _isListOpen, value);
		}

		[Ordinal(2)] 
		[RED("e3hack_isWeapon")] 
		public CBool E3hack_isWeapon
		{
			get => GetProperty(ref _e3hack_isWeapon);
			set => SetProperty(ref _e3hack_isWeapon, value);
		}

		[Ordinal(3)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetProperty(ref _currentIndex);
			set => SetProperty(ref _currentIndex, value);
		}

		[Ordinal(4)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(5)] 
		[RED("choices")] 
		public CArray<gameinteractionsvisInteractionChoiceData> Choices
		{
			get => GetProperty(ref _choices);
			set => SetProperty(ref _choices, value);
		}

		[Ordinal(6)] 
		[RED("itemIDs")] 
		public CArray<gameItemID> ItemIDs
		{
			get => GetProperty(ref _itemIDs);
			set => SetProperty(ref _itemIDs, value);
		}

		[Ordinal(7)] 
		[RED("ownerId")] 
		public entEntityID OwnerId
		{
			get => GetProperty(ref _ownerId);
			set => SetProperty(ref _ownerId, value);
		}

		[Ordinal(8)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}
	}
}
