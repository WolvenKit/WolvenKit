using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WeaponMachineInkGameController : VendingMachineInkGameController
	{
		[Ordinal(0)]  [RED("buttonRef")] public CHandle<WeaponVendorActionWidgetController> ButtonRef { get; set; }

		public WeaponMachineInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
