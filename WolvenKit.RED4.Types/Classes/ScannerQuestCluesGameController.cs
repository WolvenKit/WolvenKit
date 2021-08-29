using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerQuestCluesGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerQuestPanel;
		private CHandle<redCallbackObject> _questCluesCallbackID;
		private CHandle<redCallbackObject> _scannerDataCallbackID;
		private CBool _isValidQuestClues;
		private scannerDataStructure _scannerData;
		private CBool _hasValidScannables;
		private CArray<CWeakHandle<inkAsyncSpawnRequest>> _asyncSpawnRequests;

		[Ordinal(5)] 
		[RED("ScannerQuestPanel")] 
		public inkCompoundWidgetReference ScannerQuestPanel
		{
			get => GetProperty(ref _scannerQuestPanel);
			set => SetProperty(ref _scannerQuestPanel, value);
		}

		[Ordinal(6)] 
		[RED("questCluesCallbackID")] 
		public CHandle<redCallbackObject> QuestCluesCallbackID
		{
			get => GetProperty(ref _questCluesCallbackID);
			set => SetProperty(ref _questCluesCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("scannerDataCallbackID")] 
		public CHandle<redCallbackObject> ScannerDataCallbackID
		{
			get => GetProperty(ref _scannerDataCallbackID);
			set => SetProperty(ref _scannerDataCallbackID, value);
		}

		[Ordinal(8)] 
		[RED("isValidQuestClues")] 
		public CBool IsValidQuestClues
		{
			get => GetProperty(ref _isValidQuestClues);
			set => SetProperty(ref _isValidQuestClues, value);
		}

		[Ordinal(9)] 
		[RED("ScannerData")] 
		public scannerDataStructure ScannerData
		{
			get => GetProperty(ref _scannerData);
			set => SetProperty(ref _scannerData, value);
		}

		[Ordinal(10)] 
		[RED("hasValidScannables")] 
		public CBool HasValidScannables
		{
			get => GetProperty(ref _hasValidScannables);
			set => SetProperty(ref _hasValidScannables, value);
		}

		[Ordinal(11)] 
		[RED("asyncSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> AsyncSpawnRequests
		{
			get => GetProperty(ref _asyncSpawnRequests);
			set => SetProperty(ref _asyncSpawnRequests, value);
		}
	}
}
