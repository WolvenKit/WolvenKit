using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseDirectionalIndicatorPartLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("defaultForwardFovRange")] public CFloat DefaultForwardFovRange { get; set; }
		[Ordinal(2)] [RED("adjustedForwardFovRange")] public CFloat AdjustedForwardFovRange { get; set; }

		public gameuiBaseDirectionalIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
