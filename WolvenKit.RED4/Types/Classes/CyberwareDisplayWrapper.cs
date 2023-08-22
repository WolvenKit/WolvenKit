using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareDisplayWrapper : IScriptable
	{
		[Ordinal(0)] 
		[RED("displayData")] 
		public InventoryItemDisplayData DisplayData
		{
			get => GetPropertyValue<InventoryItemDisplayData>();
			set => SetPropertyValue<InventoryItemDisplayData>(value);
		}

		public CyberwareDisplayWrapper()
		{
			DisplayData = new InventoryItemDisplayData { ItemID = new gameItemID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
