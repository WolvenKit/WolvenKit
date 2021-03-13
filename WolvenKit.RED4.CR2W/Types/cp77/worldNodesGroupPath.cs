using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNodesGroupPath : CVariable
	{
		[Ordinal(0)] [RED("elements")] public CArray<CName> Elements { get; set; }

		public worldNodesGroupPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
