using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("Root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(1)]  [RED("ScannerSkillCheckItemName")] public CName ScannerSkillCheckItemName { get; set; }
		[Ordinal(2)]  [RED("SkillCheckObjects")] public CArray<wCHandle<inkWidget>> SkillCheckObjects { get; set; }

		public ScannerSkillCheckLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
