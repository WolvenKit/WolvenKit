using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RadialPointerController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("feedback")] public inkImageWidgetReference Feedback { get; set; }
		[Ordinal(1)]  [RED("pointer")] public inkImageWidgetReference Pointer { get; set; }

		public RadialPointerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
