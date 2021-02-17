using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerQuestCluesGameController : BaseChunkGameController
	{
		[Ordinal(5)] [RED("ScannerQuestPanel")] public inkCompoundWidgetReference ScannerQuestPanel { get; set; }
		[Ordinal(6)] [RED("questCluesCallbackID")] public CUInt32 QuestCluesCallbackID { get; set; }
		[Ordinal(7)] [RED("scannerDataCallbackID")] public CUInt32 ScannerDataCallbackID { get; set; }
		[Ordinal(8)] [RED("isValidQuestClues")] public CBool IsValidQuestClues { get; set; }
		[Ordinal(9)] [RED("ScannerData")] public scannerDataStructure ScannerData { get; set; }
		[Ordinal(10)] [RED("hasValidScannables")] public CBool HasValidScannables { get; set; }
		[Ordinal(11)] [RED("Clues")] public CArray<wCHandle<ScannerQuestClue>> Clues { get; set; }

		public ScannerQuestCluesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
