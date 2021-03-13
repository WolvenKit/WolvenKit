using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureResource : CVariable
	{
		[Ordinal(0)] [RED("renderResourceBlobPC")] public CHandle<IRenderResourceBlob> RenderResourceBlobPC { get; set; }

		public rendRenderTextureResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
