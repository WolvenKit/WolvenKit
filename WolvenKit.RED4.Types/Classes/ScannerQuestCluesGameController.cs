using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerQuestCluesGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("ScannerQuestPanel")] 
		public inkCompoundWidgetReference ScannerQuestPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("questCluesCallbackID")] 
		public CHandle<redCallbackObject> QuestCluesCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("scannerDataCallbackID")] 
		public CHandle<redCallbackObject> ScannerDataCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("isValidQuestClues")] 
		public CBool IsValidQuestClues
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("ScannerData")] 
		public scannerDataStructure ScannerData
		{
			get => GetPropertyValue<scannerDataStructure>();
			set => SetPropertyValue<scannerDataStructure>(value);
		}

		[Ordinal(10)] 
		[RED("hasValidScannables")] 
		public CBool HasValidScannables
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("asyncSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> AsyncSpawnRequests
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		public ScannerQuestCluesGameController()
		{
			ScannerQuestPanel = new();
			ScannerData = new() { QuestEntries = new() };
			AsyncSpawnRequests = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
