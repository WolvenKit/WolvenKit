using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameObjectScanStats : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("scannerData")] 
		public scannerDataStructure ScannerData
		{
			get => GetPropertyValue<scannerDataStructure>();
			set => SetPropertyValue<scannerDataStructure>(value);
		}

		public GameObjectScanStats()
		{
			ScannerData = new() { QuestEntries = new() };
		}
	}
}
