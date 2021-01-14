using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SampleUIMeasurementController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("unit")] public CEnum<EMeasurementUnit> Unit { get; set; }
		[Ordinal(1)]  [RED("unitText")] public inkTextWidgetReference UnitText { get; set; }
		[Ordinal(2)]  [RED("value")] public CFloat Value { get; set; }
		[Ordinal(3)]  [RED("valueDecreaseButton")] public inkWidgetReference ValueDecreaseButton { get; set; }
		[Ordinal(4)]  [RED("valueIncreaseButton")] public inkWidgetReference ValueIncreaseButton { get; set; }
		[Ordinal(5)]  [RED("valueText")] public inkTextWidgetReference ValueText { get; set; }

		public SampleUIMeasurementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
