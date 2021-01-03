using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnAndNode : scnSceneGraphNode
	{
		[Ordinal(0)]  [RED("numInSockets")] public CUInt32 NumInSockets { get; set; }

		public scnAndNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
