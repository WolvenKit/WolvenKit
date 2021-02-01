using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CSourceTexture : ISerializable
	{
		[Ordinal(0)]  [RED("depth")] public CUInt32 Depth { get; set; }
		[Ordinal(1)]  [RED("format")] public CEnum<ETextureRawFormat> Format { get; set; }
		[Ordinal(2)]  [RED("height")] public CUInt32 Height { get; set; }
		[Ordinal(3)]  [RED("pitch")] public CUInt32 Pitch { get; set; }
		[Ordinal(4)]  [RED("width")] public CUInt32 Width { get; set; }

		public CSourceTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
