using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisLootData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isListOpen")] 
		public CBool IsListOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("e3hack_isWeapon")] 
		public CBool E3hack_isWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("choices")] 
		public CArray<gameinteractionsvisInteractionChoiceData> Choices
		{
			get => GetPropertyValue<CArray<gameinteractionsvisInteractionChoiceData>>();
			set => SetPropertyValue<CArray<gameinteractionsvisInteractionChoiceData>>(value);
		}

		[Ordinal(6)] 
		[RED("itemIDs")] 
		public CArray<gameItemID> ItemIDs
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(7)] 
		[RED("ownerId")] 
		public entEntityID OwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(8)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinteractionsvisLootData()
		{
			IsListOpen = true;
			Choices = new();
			ItemIDs = new();
			OwnerId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
