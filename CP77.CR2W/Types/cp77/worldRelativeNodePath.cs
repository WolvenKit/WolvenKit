using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldRelativeNodePath : CVariable
	{
		[Ordinal(0)]  [RED("elements")] public CArray<worldRelativeNodePathElement> Elements { get; set; }
		[Ordinal(1)]  [RED("parentsToSkip")] public CUInt32 ParentsToSkip { get; set; }

		public worldRelativeNodePath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
