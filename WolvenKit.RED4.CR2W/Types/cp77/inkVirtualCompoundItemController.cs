using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVirtualCompoundItemController : inkButtonController
	{
		[Ordinal(10)] [RED("ToggledOff")] public inkVirtualCompoundItemControllerCallback ToggledOff { get; set; }
		[Ordinal(11)] [RED("ToggledOn")] public inkVirtualCompoundItemControllerCallback ToggledOn { get; set; }
		[Ordinal(12)] [RED("Selected")] public inkVirtualCompoundItemSelectControllerCallback Selected_656 { get; set; }
		[Ordinal(13)] [RED("Deselected")] public inkVirtualCompoundItemControllerCallback Deselected { get; set; }
		[Ordinal(14)] [RED("Added")] public inkVirtualCompoundItemControllerCallback Added { get; set; }

		public inkVirtualCompoundItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
