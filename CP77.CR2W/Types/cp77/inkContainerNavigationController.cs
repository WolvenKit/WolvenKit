using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkContainerNavigationController : inkDiscreteNavigationController
	{
		[Ordinal(0)]  [RED("overrideEntries")] public CArray<inkNavigationOverrideEntry> OverrideEntries { get; set; }
		[Ordinal(1)]  [RED("useGlobalInput")] public CBool UseGlobalInput { get; set; }

		public inkContainerNavigationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
