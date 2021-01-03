using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkInputDisplayController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("canvasRef")] public inkWidgetReference CanvasRef { get; set; }
		[Ordinal(1)]  [RED("fixedIconHeight")] public CFloat FixedIconHeight { get; set; }
		[Ordinal(2)]  [RED("gamepadHoldIndicatorLibraryRef")] public inkWidgetLibraryReference GamepadHoldIndicatorLibraryRef { get; set; }
		[Ordinal(3)]  [RED("holdIndicationType")] public CEnum<inkInputHintHoldIndicationType> HoldIndicationType { get; set; }
		[Ordinal(4)]  [RED("holdIndicatorContainerRef")] public inkCompoundWidgetReference HoldIndicatorContainerRef { get; set; }
		[Ordinal(5)]  [RED("iconRef")] public inkWidgetReference IconRef { get; set; }
		[Ordinal(6)]  [RED("inputActionName")] public CName InputActionName { get; set; }
		[Ordinal(7)]  [RED("keyboardHoldIndicatorLibraryRef")] public inkWidgetLibraryReference KeyboardHoldIndicatorLibraryRef { get; set; }
		[Ordinal(8)]  [RED("nameRef")] public inkWidgetReference NameRef { get; set; }
		[Ordinal(9)]  [RED("supportAnimatedHoldIndicator")] public CBool SupportAnimatedHoldIndicator { get; set; }

		public inkInputDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
