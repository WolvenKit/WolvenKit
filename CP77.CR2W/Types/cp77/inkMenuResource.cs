using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkMenuResource : CResource
	{
		[Ordinal(0)]  [RED("initialScenarioName")] public CName InitialScenarioName { get; set; }
		[Ordinal(1)]  [RED("menusEntries")] public CArray<inkMenuEntry> MenusEntries { get; set; }
		[Ordinal(2)]  [RED("scenariosNames")] public CArray<CName> ScenariosNames { get; set; }

		public inkMenuResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
