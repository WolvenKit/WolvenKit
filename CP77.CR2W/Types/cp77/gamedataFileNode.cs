using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedataFileNode : gamedataDataNode
	{
		[Ordinal(0)]  [RED("packageName")] public CString PackageName { get; set; }
		[Ordinal(1)]  [RED("packageDependencies", 16)] public CStatic<wCHandle<gamedataPackageNode>> PackageDependencies { get; set; }
		[Ordinal(2)]  [RED("package")] public wCHandle<gamedataPackageNode> Package { get; set; }
		[Ordinal(3)]  [RED("variables")] public CArray<CHandle<gamedataVariableNode>> Variables { get; set; }
		[Ordinal(4)]  [RED("groups")] public CArray<CHandle<gamedataGroupNode>> Groups { get; set; }

		public gamedataFileNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
