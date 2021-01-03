using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSceneGraph : ISerializable
	{
		[Ordinal(0)]  [RED("endNodes")] public CArray<scnNodeId> EndNodes { get; set; }
		[Ordinal(1)]  [RED("graph")] public CArray<CHandle<scnSceneGraphNode>> Graph { get; set; }
		[Ordinal(2)]  [RED("startNodes")] public CArray<scnNodeId> StartNodes { get; set; }

		public scnSceneGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
