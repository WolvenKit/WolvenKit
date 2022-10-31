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
		[RED("dedicatedMods")] 
		public CArray<CHandle<UIInventoryItemModAttachment>> DedicatedMods
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemModAttachment>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemModAttachment>>>(value);
		}

		[Ordinal(4)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		public UIInventoryItemModsManager()
		{
			EmptySlots = new();
			UsedSlots = new();
			Mods = new();
			DedicatedMods = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
