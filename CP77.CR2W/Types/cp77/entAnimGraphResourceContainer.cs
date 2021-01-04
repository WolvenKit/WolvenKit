using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAnimGraphResourceContainer : entIComponent
	{
		[Ordinal(0)]  [RED("animGraphLookupTable")] public CArray<entAnimGraphResourceContainerEntry> AnimGraphLookupTable { get; set; }

		public entAnimGraphResourceContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
