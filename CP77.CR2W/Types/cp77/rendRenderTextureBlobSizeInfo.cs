using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobSizeInfo : CVariable
	{
		[Ordinal(0)]  [RED("depth")] public CUInt16 Depth { get; set; }
		[Ordinal(1)]  [RED("height")] public CUInt16 Height { get; set; }
		[Ordinal(2)]  [RED("width")] public CUInt16 Width { get; set; }

		public rendRenderTextureBlobSizeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
