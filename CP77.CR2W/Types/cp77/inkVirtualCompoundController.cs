using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkVirtualCompoundController : inkDiscreteNavigationController
	{
		[Ordinal(4)] [RED("ItemSelected")] public inkVirtualCompoundControllerCallback ItemSelected { get; set; }
		[Ordinal(5)] [RED("ItemActivated")] public inkVirtualCompoundControllerCallback ItemActivated { get; set; }

		public inkVirtualCompoundController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
