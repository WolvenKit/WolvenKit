using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkMultiChildren : inkChildren
	{
		[Ordinal(0)]  [RED("children")] public CArray<CHandle<inkWidget>> Children { get; set; }

		public inkMultiChildren(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
