using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DispenceItemFromVendor : ActionBool
	{
		[Ordinal(25)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(26)] 
		[RED("price")] 
		public CInt32 Price
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(27)] 
		[RED("atlasTexture")] 
		public CName AtlasTexture
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DispenceItemFromVendor()
		{
			RequesterID = new entEntityID();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;
			ItemID = new gameItemID();
			Price = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
