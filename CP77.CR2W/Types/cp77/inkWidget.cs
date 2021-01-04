using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkWidget : IScriptable
	{
		[Ordinal(0)]  [RED("affectsLayoutWhenHidden")] public CBool AffectsLayoutWhenHidden { get; set; }
		[Ordinal(1)]  [RED("canSupportFocus")] public CBool CanSupportFocus { get; set; }
		[Ordinal(2)]  [RED("effects")] public CArray<CHandle<inkIEffect>> Effects { get; set; }
		[Ordinal(3)]  [RED("fitToContent")] public CBool FitToContent { get; set; }
		[Ordinal(4)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(5)]  [RED("layout")] public inkWidgetLayout Layout { get; set; }
		[Ordinal(6)]  [RED("logicController")] public CHandle<inkWidgetLogicController> LogicController { get; set; }
		[Ordinal(7)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(8)]  [RED("opacity")] public CFloat Opacity { get; set; }
		[Ordinal(9)]  [RED("parentWidget")] public wCHandle<inkWidget> ParentWidget { get; set; }
		[Ordinal(10)]  [RED("propertyManager")] public CHandle<inkPropertyManager> PropertyManager { get; set; }
		[Ordinal(11)]  [RED("renderTransform")] public inkUITransform RenderTransform { get; set; }
		[Ordinal(12)]  [RED("renderTransformPivot")] public Vector2 RenderTransformPivot { get; set; }
		[Ordinal(13)]  [RED("secondaryControllers")] public CArray<CHandle<inkWidgetLogicController>> SecondaryControllers { get; set; }
		[Ordinal(14)]  [RED("size")] public Vector2 Size { get; set; }
		[Ordinal(15)]  [RED("state")] public CName State { get; set; }
		[Ordinal(16)]  [RED("style")] public CHandle<inkStyleResourceWrapper> Style { get; set; }
		[Ordinal(17)]  [RED("tintColor")] public HDRColor TintColor { get; set; }
		[Ordinal(18)]  [RED("userData")] public CArray<CHandle<inkUserData>> UserData { get; set; }
		[Ordinal(19)]  [RED("visible")] public CBool Visible { get; set; }

		public inkWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
