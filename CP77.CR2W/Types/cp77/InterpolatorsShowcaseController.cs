using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InterpolatorsShowcaseController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("interpolationType")] public CEnum<inkanimInterpolationType> InterpolationType { get; set; }
		[Ordinal(1)]  [RED("interpolationMode")] public CEnum<inkanimInterpolationMode> InterpolationMode { get; set; }
		[Ordinal(2)]  [RED("overlay")] public wCHandle<inkWidget> Overlay { get; set; }
		[Ordinal(3)]  [RED("heightBar")] public wCHandle<inkWidget> HeightBar { get; set; }
		[Ordinal(4)]  [RED("widthBar")] public wCHandle<inkWidget> WidthBar { get; set; }
		[Ordinal(5)]  [RED("graphPointer")] public wCHandle<inkWidget> GraphPointer { get; set; }
		[Ordinal(6)]  [RED("counterText")] public wCHandle<inkTextWidget> CounterText { get; set; }
		[Ordinal(7)]  [RED("sizeWidget")] public wCHandle<inkWidget> SizeWidget { get; set; }
		[Ordinal(8)]  [RED("rotationWidget")] public wCHandle<inkWidget> RotationWidget { get; set; }
		[Ordinal(9)]  [RED("marginWidget")] public wCHandle<inkWidget> MarginWidget { get; set; }
		[Ordinal(10)]  [RED("colorWidget")] public wCHandle<inkWidget> ColorWidget { get; set; }
		[Ordinal(11)]  [RED("sizeAnim")] public CHandle<inkanimDefinition> SizeAnim { get; set; }
		[Ordinal(12)]  [RED("rotationAnim")] public CHandle<inkanimDefinition> RotationAnim { get; set; }
		[Ordinal(13)]  [RED("marginAnim")] public CHandle<inkanimDefinition> MarginAnim { get; set; }
		[Ordinal(14)]  [RED("colorAnim")] public CHandle<inkanimDefinition> ColorAnim { get; set; }
		[Ordinal(15)]  [RED("followTimelineAnim")] public CHandle<inkanimDefinition> FollowTimelineAnim { get; set; }
		[Ordinal(16)]  [RED("interpolateAnim")] public CHandle<inkanimDefinition> InterpolateAnim { get; set; }
		[Ordinal(17)]  [RED("startMargin")] public inkMargin StartMargin { get; set; }
		[Ordinal(18)]  [RED("animLength")] public CFloat AnimLength { get; set; }
		[Ordinal(19)]  [RED("animConstructor")] public CHandle<AnimationsConstructor> AnimConstructor { get; set; }

		public InterpolatorsShowcaseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
