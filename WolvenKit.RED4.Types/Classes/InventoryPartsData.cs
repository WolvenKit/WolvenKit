using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryPartsData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("SlotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("ItemData")] 
		public CArray<gameInventoryItemData> ItemData
		{
			get => GetPropertyValue<CArray<gameInventoryItemData>>();
			set => SetPropertyValue<CArray<gameInventoryItemData>>(value);
		}

		[Ordinal(2)] 
		[RED("ToRebuild")] 
		public CBool ToRebuild
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InventoryPartsData()
		{
			ItemData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
