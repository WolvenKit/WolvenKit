using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkMenuResource : CResource
	{
		[Ordinal(0)]  [RED("menusEntries")] public CArray<inkMenuEntry> MenusEntries { get; set; }
		[Ordinal(1)]  [RED("scenariosNames")] public CArray<CName> ScenariosNames { get; set; }
		[Ordinal(2)]  [RED("initialScenarioName")] public CName InitialScenarioName { get; set; }

		public inkMenuResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
