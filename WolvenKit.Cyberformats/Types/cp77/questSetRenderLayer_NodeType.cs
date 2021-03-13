using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetRenderLayer_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] [RED("renderSceneLayer")] public CEnum<RenderSceneLayer> RenderSceneLayer { get; set; }

		public questSetRenderLayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
