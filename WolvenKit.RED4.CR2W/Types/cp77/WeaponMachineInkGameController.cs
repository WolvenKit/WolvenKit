using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponMachineInkGameController : VendingMachineInkGameController
	{
		[Ordinal(25)] [RED("buttonRef")] public CHandle<WeaponVendorActionWidgetController> ButtonRef { get; set; }

		public WeaponMachineInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
