using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeaponVendorActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(28)] [RED("buttonText")] public inkTextWidgetReference ButtonText { get; set; }
		[Ordinal(29)] [RED("standardButtonContainer")] public inkWidgetReference StandardButtonContainer { get; set; }
		[Ordinal(30)] [RED("hoveredButtonContainer")] public inkWidgetReference HoveredButtonContainer { get; set; }
		[Ordinal(31)] [RED("buttonState")] public CEnum<ButtonStatus> ButtonState { get; set; }
		[Ordinal(32)] [RED("hoverState")] public CEnum<HoverStatus> HoverState { get; set; }
		[Ordinal(33)] [RED("isBusy")] public CBool IsBusy { get; set; }

		public WeaponVendorActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
