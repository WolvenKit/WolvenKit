using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkWindowDrawMetrics : CVariable
	{
		[Ordinal(0)]  [RED("allTextures")] public CArray<Vector2> AllTextures { get; set; }
		[Ordinal(1)]  [RED("drawMetrics")] public CArray<inkSingleDrawMetric> DrawMetrics { get; set; }
		[Ordinal(2)]  [RED("maxUsedTextureTypes")] public CArray<CUInt32> MaxUsedTextureTypes { get; set; }
		[Ordinal(3)]  [RED("textureSizeTypes")] public CArray<Vector2> TextureSizeTypes { get; set; }
		[Ordinal(4)]  [RED("textureTypeTotal")] public CArray<CUInt32> TextureTypeTotal { get; set; }

		public inkWindowDrawMetrics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
