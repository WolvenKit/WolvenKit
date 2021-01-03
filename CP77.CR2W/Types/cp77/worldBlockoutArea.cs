using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutArea : ISerializable
	{
		[Ordinal(0)]  [RED("children")] public CArray<CUInt32> Children { get; set; }
		[Ordinal(1)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(2)]  [RED("increaseTerrainStreamingDistance")] public CBool IncreaseTerrainStreamingDistance { get; set; }
		[Ordinal(3)]  [RED("isFree")] public CBool IsFree { get; set; }
		[Ordinal(4)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(5)]  [RED("outlines")] public CArray<CHandle<worldBlockoutAreaOutline>> Outlines { get; set; }
		[Ordinal(6)]  [RED("parent")] public CUInt32 Parent { get; set; }

		public worldBlockoutArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
