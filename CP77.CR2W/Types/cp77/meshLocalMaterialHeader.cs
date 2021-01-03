using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshLocalMaterialHeader : CVariable
	{
		[Ordinal(0)]  [RED("offset")] public CUInt32 Offset { get; set; }
		[Ordinal(1)]  [RED("size")] public CUInt32 Size { get; set; }

		public meshLocalMaterialHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
