using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutAreaOutline : ISerializable
	{
		[Ordinal(0)]  [RED("edges")] public CArray<CUInt32> Edges { get; set; }
		[Ordinal(1)]  [RED("points")] public CArray<CUInt32> Points { get; set; }

		public worldBlockoutAreaOutline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
