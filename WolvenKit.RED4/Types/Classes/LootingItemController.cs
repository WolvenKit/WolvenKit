using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LootingItemController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("itemNameText")] 
		public CWeakHandle<inkTextWidget> ItemNameText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("isCurrentlySelected")] 
		public CBool IsCurrentlySelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("itemType")] 
		public inkTextWidgetReference ItemType
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("itemWeight")] 
		public inkTextWidgetReference ItemWeight
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("itemQuantity")] 
		public inkTextWidgetReference ItemQuantity
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemQualityBar")] 
		public inkWidgetReference ItemQualityBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("itemSelection")] 
		public inkWidgetReference ItemSelection
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("itemIcon")] 
		public inkImageWidgetReference ItemIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public LootingItemController()
		{
			ItemName = new inkTextWidgetReference();
			ItemType = new inkTextWidgetReference();
			ItemWeight = new inkTextWidgetReference();
			ItemQuantity = new inkTextWidgetReference();
			ItemQualityBar = new inkWidgetReference();
			ItemSelection = new inkWidgetReference();
			ItemIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
