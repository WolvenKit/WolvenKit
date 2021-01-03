using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkContainerNavigationController : inkDiscreteNavigationController
	{
		[Ordinal(0)]  [RED("overrideEntries")] public CArray<inkNavigationOverrideEntry> OverrideEntries { get; set; }
		[Ordinal(1)]  [RED("useGlobalInput")] public CBool UseGlobalInput { get; set; }

		public inkContainerNavigationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
