using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendIRenderTextureBlob : IRenderResourceBlob
	{
		[Ordinal(0)] [RED("header")] public rendRenderTextureBlobHeader Header { get; set; }
		[Ordinal(1)] [RED("textureData")] public serializationDeferredDataBuffer TextureData { get; set; }

		public rendIRenderTextureBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
