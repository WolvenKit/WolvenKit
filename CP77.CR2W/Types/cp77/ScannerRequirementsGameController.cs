using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerRequirementsGameController : BaseChunkGameController
	{
		[Ordinal(5)] [RED("ScannerRequirementsRightPanel")] public inkCompoundWidgetReference ScannerRequirementsRightPanel { get; set; }
		[Ordinal(6)] [RED("requirementsCallbackID")] public CUInt32 RequirementsCallbackID { get; set; }
		[Ordinal(7)] [RED("isValidRequirements")] public CBool IsValidRequirements { get; set; }
		[Ordinal(8)] [RED("requirementWidgets")] public CArray<wCHandle<inkWidget>> RequirementWidgets { get; set; }

		public ScannerRequirementsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
