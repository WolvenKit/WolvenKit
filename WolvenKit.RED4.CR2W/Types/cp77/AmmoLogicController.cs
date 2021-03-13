using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmmoLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("count")] public CUInt32 Count { get; set; }
		[Ordinal(2)] [RED("capacity")] public CUInt32 Capacity { get; set; }

		public AmmoLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
