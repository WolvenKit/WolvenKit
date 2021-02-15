using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("ScannerSkillCheckItemName")] public CName ScannerSkillCheckItemName { get; set; }
		[Ordinal(2)] [RED("SkillCheckObjects")] public CArray<wCHandle<inkWidget>> SkillCheckObjects { get; set; }
		[Ordinal(3)] [RED("Root")] public wCHandle<inkCompoundWidget> Root { get; set; }

		public ScannerSkillCheckLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
