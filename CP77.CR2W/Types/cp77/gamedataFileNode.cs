using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedataFileNode : gamedataDataNode
	{
		[Ordinal(0)]  [RED("groups")] public CArray<CHandle<gamedataGroupNode>> Groups { get; set; }
		[Ordinal(1)]  [RED("package")] public wCHandle<gamedataPackageNode> Package { get; set; }
		[Ordinal(2)]  [RED("packageDependencies", 16)] public CStatic<wCHandle<gamedataPackageNode>> PackageDependencies { get; set; }
		[Ordinal(3)]  [RED("packageName")] public CString PackageName { get; set; }
		[Ordinal(4)]  [RED("variables")] public CArray<CHandle<gamedataVariableNode>> Variables { get; set; }

		public gamedataFileNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
