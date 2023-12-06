using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemRecipe : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetItem")] 
		public TweakDBID TargetItem
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("hideOnItemsAdded")] 
		public CArray<gameItemID> HideOnItemsAdded
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(2)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ItemRecipe()
		{
			HideOnItemsAdded = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
