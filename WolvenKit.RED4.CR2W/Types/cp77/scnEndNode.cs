using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEndNode : scnSceneGraphNode
	{
		[Ordinal(3)] [RED("type")] public CEnum<scnEndNodeNsType> Type { get; set; }

		public scnEndNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
