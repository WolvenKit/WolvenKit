using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DispenceItemFromVendor : ActionBool
	{
		[Ordinal(39)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(40)] 
		[RED("price")] 
		public CInt32 Price
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(41)] 
		[RED("atlasTexture")] 
		public CName AtlasTexture
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DispenceItemFromVendor()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			ItemID = new gameItemID();
			Price = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
