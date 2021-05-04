using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerQuestCluesGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerQuestPanel;
		private CUInt32 _questCluesCallbackID;
		private CUInt32 _scannerDataCallbackID;
		private CBool _isValidQuestClues;
		private scannerDataStructure _scannerData;
		private CBool _hasValidScannables;
		private CArray<wCHandle<ScannerQuestClue>> _clues;

		[Ordinal(5)] 
		[RED("ScannerQuestPanel")] 
		public inkCompoundWidgetReference ScannerQuestPanel
		{
			get => GetProperty(ref _scannerQuestPanel);
			set => SetProperty(ref _scannerQuestPanel, value);
		}

		[Ordinal(6)] 
		[RED("questCluesCallbackID")] 
		public CUInt32 QuestCluesCallbackID
		{
			get => GetProperty(ref _questCluesCallbackID);
			set => SetProperty(ref _questCluesCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("scannerDataCallbackID")] 
		public CUInt32 ScannerDataCallbackID
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
		[RED("Clues")] 
		public CArray<wCHandle<ScannerQuestClue>> Clues
		{
			get => GetProperty(ref _clues);
			set => SetProperty(ref _clues, value);
		}

		public ScannerQuestCluesGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
