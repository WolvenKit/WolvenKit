using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerVulnerabilitiesGameController : BaseChunkGameController
	{
		[Ordinal(0)]  [RED("chunkBlackboard")] public CHandle<gameIBlackboard> ChunkBlackboard { get; set; }
		[Ordinal(1)]  [RED("chunkBlackboardDef")] public CHandle<UI_ScannerModulesDef> ChunkBlackboardDef { get; set; }
		[Ordinal(2)]  [RED("questClueBlackboardDef")] public CHandle<UI_ScannerDef> QuestClueBlackboardDef { get; set; }
		[Ordinal(3)]  [RED("ScannerVulnerabilitiesRightPanel")] public inkCompoundWidgetReference ScannerVulnerabilitiesRightPanel { get; set; }
		[Ordinal(4)]  [RED("vulnerabilitiesCallbackID")] public CUInt32 VulnerabilitiesCallbackID { get; set; }
		[Ordinal(5)]  [RED("isValidVulnerabilities")] public CBool IsValidVulnerabilities { get; set; }
		[Ordinal(6)]  [RED("vulnerabilityWidgets")] public CArray<wCHandle<inkWidget>> VulnerabilityWidgets { get; set; }

		public ScannerVulnerabilitiesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
