using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseDirectionalIndicatorPartLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("adjustedForwardFovRange")] public CFloat AdjustedForwardFovRange { get; set; }
		[Ordinal(1)]  [RED("defaultForwardFovRange")] public CFloat DefaultForwardFovRange { get; set; }

		public gameuiBaseDirectionalIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
