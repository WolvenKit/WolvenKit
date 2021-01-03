using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendIRenderTextureBlob : IRenderResourceBlob
	{
		[Ordinal(0)]  [RED("header")] public rendRenderTextureBlobHeader Header { get; set; }
		[Ordinal(1)]  [RED("textureData")] public serializationDeferredDataBuffer TextureData { get; set; }

		public rendIRenderTextureBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
