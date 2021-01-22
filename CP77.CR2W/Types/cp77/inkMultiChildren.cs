using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkMultiChildren : inkChildren
	{
		[Ordinal(0)]  [RED("children")] public CArray<CHandle<inkWidget>> Children { get; set; }

		public inkMultiChildren(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
