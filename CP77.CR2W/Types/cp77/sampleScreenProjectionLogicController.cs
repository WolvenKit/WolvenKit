using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleScreenProjectionLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("projection")] public CHandle<inkScreenProjection> Projection { get; set; }
		[Ordinal(1)]  [RED("widgetPos")] public wCHandle<inkTextWidget> WidgetPos { get; set; }
		[Ordinal(2)]  [RED("worldPos")] public wCHandle<inkTextWidget> WorldPos { get; set; }

		public sampleScreenProjectionLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
