using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatsProgressController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("XpWrapper")] public inkWidgetReference XpWrapper { get; set; }
		[Ordinal(1)]  [RED("barLenght")] public CFloat BarLenght { get; set; }
		[Ordinal(2)]  [RED("currentLevelRef")] public inkTextWidgetReference CurrentLevelRef { get; set; }
		[Ordinal(3)]  [RED("currentPersentageRef")] public inkTextWidgetReference CurrentPersentageRef { get; set; }
		[Ordinal(4)]  [RED("currentXpRef")] public inkTextWidgetReference CurrentXpRef { get; set; }
		[Ordinal(5)]  [RED("labelRef")] public inkTextWidgetReference LabelRef { get; set; }
		[Ordinal(6)]  [RED("maxXpRef")] public inkTextWidgetReference MaxXpRef { get; set; }
		[Ordinal(7)]  [RED("maxXpWrapper")] public inkWidgetReference MaxXpWrapper { get; set; }
		[Ordinal(8)]  [RED("progressBar")] public inkWidgetReference ProgressBar { get; set; }
		[Ordinal(9)]  [RED("progressBarFill")] public inkWidgetReference ProgressBarFill { get; set; }
		[Ordinal(10)]  [RED("progressMarkerBar")] public inkWidgetReference ProgressMarkerBar { get; set; }

		public StatsProgressController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
