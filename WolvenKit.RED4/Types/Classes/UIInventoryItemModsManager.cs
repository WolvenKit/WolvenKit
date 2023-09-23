using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemModsManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("emptySlots")] 
		public CArray<TweakDBID> EmptySlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(1)] 
		[RED("usedSlots")] 
		public CArray<TweakDBID> UsedSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(2)] 
		[RED("mods")] 
		public CArray<CHandle<UIInventoryItemMod>> Mods
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemMod>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemMod>>>(value);
		}

		[Ordinal(3)] 
		[RED("attachments")] 
		public CArray<CHandle<UIInventoryItemModAttachment>> Attachments
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemModAttachment>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemModAttachment>>>(value);
		}

		[Ordinal(4)] 
		[RED("dedicatedMod")] 
		public CHandle<UIInventoryItemModAttachment> DedicatedMod
		{
			get => GetPropertyValue<CHandle<UIInventoryItemModAttachment>>();
			set => SetPropertyValue<CHandle<UIInventoryItemModAttachment>>(value);
		}

		[Ordinal(5)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		public UIInventoryItemModsManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
