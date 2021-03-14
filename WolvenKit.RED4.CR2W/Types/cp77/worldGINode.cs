using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldGINode : worldNode
	{
		[Ordinal(4)] [RED("data")] public raRef<CGIDataResource> Data { get; set; }
		[Ordinal(5)] [RED("location", 3)] public CArrayFixedSize<CInt16> Location { get; set; }

		public worldGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
