using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnSceneGraph : ISerializable
	{
		[Ordinal(0)]  [RED("graph")] public CArray<CHandle<scnSceneGraphNode>> Graph { get; set; }
		[Ordinal(1)]  [RED("startNodes")] public CArray<scnNodeId> StartNodes { get; set; }
		[Ordinal(2)]  [RED("endNodes")] public CArray<scnNodeId> EndNodes { get; set; }

		public scnSceneGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
