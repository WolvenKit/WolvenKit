using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendRenderMeshBlob : IRenderResourceBlob
	{
		[Ordinal(0)]  [RED("header")] public rendRenderMeshBlobHeader Header { get; set; }
		[Ordinal(1)]  [RED("renderBuffer")] public DataBuffer RenderBuffer { get; set; }

		public rendRenderMeshBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
