using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			DisplayData = new() { ItemID = new() };
		}
	}
}
