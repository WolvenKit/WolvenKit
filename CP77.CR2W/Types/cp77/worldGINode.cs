using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldGINode : worldNode
	{
		[Ordinal(0)]  [RED("data")] public raRef<CGIDataResource> Data { get; set; }
		[Ordinal(1)]  [RED("location", 3)] public CArrayFixedSize<CInt16> Location { get; set; }

		public worldGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
