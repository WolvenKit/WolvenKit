using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberwareDisplayWrapper : IScriptable
	{
		private InventoryItemDisplayData _displayData;

		[Ordinal(0)] 
		[RED("displayData")] 
		public InventoryItemDisplayData DisplayData
		{
			get => GetProperty(ref _displayData);
			set => SetProperty(ref _displayData, value);
		}
	}
}
