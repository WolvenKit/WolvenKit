using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerRequirementsGameController : BaseChunkGameController
	{
		[Ordinal(0)]  [RED("ScannerRequirementsRightPanel")] public inkCompoundWidgetReference ScannerRequirementsRightPanel { get; set; }
		[Ordinal(1)]  [RED("isValidRequirements")] public CBool IsValidRequirements { get; set; }
		[Ordinal(2)]  [RED("requirementWidgets")] public CArray<wCHandle<inkWidget>> RequirementWidgets { get; set; }
		[Ordinal(3)]  [RED("requirementsCallbackID")] public CUInt32 RequirementsCallbackID { get; set; }

		public ScannerRequirementsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
