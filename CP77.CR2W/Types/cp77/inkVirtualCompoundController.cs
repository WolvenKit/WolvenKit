using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkVirtualCompoundController : inkDiscreteNavigationController
	{
		[Ordinal(0)]  [RED("ItemActivated")] public inkVirtualCompoundControllerCallback ItemActivated { get; set; }
		[Ordinal(1)]  [RED("ItemSelected")] public inkVirtualCompoundControllerCallback ItemSelected { get; set; }

		public inkVirtualCompoundController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
