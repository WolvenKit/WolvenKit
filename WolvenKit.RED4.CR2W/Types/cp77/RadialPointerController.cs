using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialPointerController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("pointer")] public inkImageWidgetReference Pointer { get; set; }
		[Ordinal(2)] [RED("feedback")] public inkImageWidgetReference Feedback { get; set; }

		public RadialPointerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
