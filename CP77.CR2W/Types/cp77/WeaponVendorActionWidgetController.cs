using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeaponVendorActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(0)]  [RED("buttonState")] public CEnum<ButtonStatus> ButtonState { get; set; }
		[Ordinal(1)]  [RED("buttonText")] public inkTextWidgetReference ButtonText { get; set; }
		[Ordinal(2)]  [RED("hoverState")] public CEnum<HoverStatus> HoverState { get; set; }
		[Ordinal(3)]  [RED("hoveredButtonContainer")] public inkWidgetReference HoveredButtonContainer { get; set; }
		[Ordinal(4)]  [RED("isBusy")] public CBool IsBusy { get; set; }
		[Ordinal(5)]  [RED("standardButtonContainer")] public inkWidgetReference StandardButtonContainer { get; set; }

		public WeaponVendorActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
