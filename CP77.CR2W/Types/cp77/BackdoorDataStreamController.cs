using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BackdoorDataStreamController : BackdoorInkGameController
	{
		[Ordinal(0)]  [RED("canvasC1")] public inkWidgetReference CanvasC1 { get; set; }
		[Ordinal(1)]  [RED("canvasC2")] public inkWidgetReference CanvasC2 { get; set; }
		[Ordinal(2)]  [RED("canvasC3")] public inkWidgetReference CanvasC3 { get; set; }
		[Ordinal(3)]  [RED("canvasC4")] public inkWidgetReference CanvasC4 { get; set; }
		[Ordinal(4)]  [RED("hackedGroup")] public inkWidgetReference HackedGroup { get; set; }
		[Ordinal(5)]  [RED("idleCanvas1")] public inkWidgetReference IdleCanvas1 { get; set; }
		[Ordinal(6)]  [RED("idleCanvas2")] public inkWidgetReference IdleCanvas2 { get; set; }
		[Ordinal(7)]  [RED("idleCanvas3")] public inkWidgetReference IdleCanvas3 { get; set; }
		[Ordinal(8)]  [RED("idleCanvas4")] public inkWidgetReference IdleCanvas4 { get; set; }
		[Ordinal(9)]  [RED("idleGroup")] public new inkWidgetReference IdleGroup { get; set; }
		[Ordinal(10)]  [RED("idleVPanelC1")] public inkWidgetReference IdleVPanelC1 { get; set; }
		[Ordinal(11)]  [RED("idleVPanelC2")] public inkWidgetReference IdleVPanelC2 { get; set; }
		[Ordinal(12)]  [RED("idleVPanelC3")] public inkWidgetReference IdleVPanelC3 { get; set; }
		[Ordinal(13)]  [RED("idleVPanelC4")] public inkWidgetReference IdleVPanelC4 { get; set; }

		public BackdoorDataStreamController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
