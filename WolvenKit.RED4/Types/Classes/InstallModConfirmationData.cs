using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InstallModConfirmationData : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("partId")] 
		public gameItemID PartId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("telemetryItemData")] 
		public gameTelemetryInventoryItem TelemetryItemData
		{
			get => GetPropertyValue<gameTelemetryInventoryItem>();
			set => SetPropertyValue<gameTelemetryInventoryItem>(value);
		}

		[Ordinal(4)] 
		[RED("telemetryPartData")] 
		public gameTelemetryInventoryItem TelemetryPartData
		{
			get => GetPropertyValue<gameTelemetryInventoryItem>();
			set => SetPropertyValue<gameTelemetryInventoryItem>(value);
		}

		public InstallModConfirmationData()
		{
			ItemId = new gameItemID();
			PartId = new gameItemID();
			TelemetryItemData = new gameTelemetryInventoryItem { ItemID = new gameItemID(), Quality = Enums.gamedataQuality.Invalid, ItemType = Enums.gamedataItemType.Invalid, ItemLevel = -1 };
			TelemetryPartData = new gameTelemetryInventoryItem { ItemID = new gameItemID(), Quality = Enums.gamedataQuality.Invalid, ItemType = Enums.gamedataItemType.Invalid, ItemLevel = -1 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
